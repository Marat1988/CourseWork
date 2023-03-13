using Dapper;
using HostelStudent.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HostelStudent
{
    public partial class FormAddEdtToRoomStudent : Form
    {
        private int action;
        private int studentId;

        public FormAddEdtToRoomStudent(int action, int studentId)
        {
            InitializeComponent();
            this.action = action;
            this.studentId = studentId;
            Text = (action == 0) ? "Добавление данных" : "Изменение данных";
            string sqlStudent = "SELECT * FROM Students";
            string sqlRooms = "SELECT * FROM Rooms";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
            {
                /*Студенты*/
                var infoStudent = connection.Query<Students>(sqlStudent).Select(p => new
                {
                    p.StudentId,
                    p.FullName
                }).ToList();
                var dictionaryStudent = infoStudent.ToDictionary(x => x.StudentId, y => y.FullName);
                comboBoxChooseStudent.DataSource = new BindingSource(dictionaryStudent, null);
                comboBoxChooseStudent.DisplayMember = "Value";
                comboBoxChooseStudent.ValueMember = "Key";
                /*Комнаты*/
                var infoRoom = connection.Query<Rooms>(sqlRooms).Select(p => new
                {
                    p.RoomId,
                    p.Number
                }).ToList();
                var dictionaryRooms = infoRoom.ToDictionary(x => x.RoomId, y => y.Number);
                comboBoxChooseRooms.DataSource = new BindingSource(dictionaryRooms, null);
                comboBoxChooseRooms.DisplayMember = "Value";
                comboBoxChooseRooms.ValueMember = "Key";
            }
            if (action > 0)
            {
                comboBoxChooseStudent.SelectedIndex = getSelectIndex(studentId, comboBoxChooseStudent);
                comboBoxChooseStudent.Enabled = false;
            }
        }

        private void ExecuteProcudure(int action, int studentId, int roomId, DateTime dateSettlement)
        {
            try
            {
                using (var connecton = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Action", action);
                    parameters.Add("@StudentId", studentId);
                    parameters.Add("@RoomId", roomId);
                    parameters.Add("@DateSettlement", dateSettlement);
                    parameters.Add("@LineAnswer", "", dbType: DbType.String, direction: ParameterDirection.Output);
                    connecton.Execute("up_upd_AddEditDeleteStudentRoom", parameters, commandType: CommandType.StoredProcedure);
                    if (parameters.Get<string>("@LineAnswer").Length > 0)
                    {
                        MessageBox.Show(parameters.Get<string>("@LineAnswer").ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Данные успешно сохранены", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            ExecuteProcudure(action, ((KeyValuePair<int, string>)comboBoxChooseStudent.SelectedItem).Key, ((KeyValuePair<int, string>)comboBoxChooseRooms.SelectedItem).Key, dateTimePickerDateSettlement.Value.Date);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int getSelectIndex(int key, ComboBox comboBoxChoose)
        {
            for (int i = 0; i < comboBoxChoose.Items.Count; i++)
            {
                if (((KeyValuePair<int, string>)comboBoxChoose.Items[i]).Key == key)
                    return i;
            }
            return -1;
        }

    }
}
