using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelStudent
{
    public partial class MainForm : Form
    {
        private int studentId;

        public MainForm()
        {
            InitializeComponent();
            ToolStripMenuItemRefreshData_Click(null, null);
        }

        private void ToolStripMenuItemRefreshData_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
                {
                    var queryStudent = connection.Query("up_sel_InfoStudent", commandType: CommandType.StoredProcedure);
                    var dataStudent = (from p in queryStudent
                                       select new {p.StudentId, p.FullName, p.TelNumber,
                                                   p.Sex, p.DateOfBirth, p.Department, p.DateSettlement, p.TypeNameRoom}).ToList();
                    dataGridViewInfoStudent.DataSource = null;
                    dataGridViewInfoStudent.DataSource = dataStudent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            toolStripStatusLabelCountStudent.Text = dataGridViewInfoStudent.Rows.Count.ToString();
        }

        private void ToolStripMenuItemAddStudentRoom_Click(object sender, EventArgs e)
        {
            FormAddEdtToRoomStudent formAddEdtToRoomStudent = new FormAddEdtToRoomStudent(0, studentId);
            formAddEdtToRoomStudent.ShowDialog();
            ToolStripMenuItemRefreshData_Click(sender, e);
        }

        private void dataGridViewInfoStudent_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewInfoStudent.SelectedRows)
            {
                studentId = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e) => Close();
      
        private void ToolStripMenuItemEditStudentRoom_Click(object sender, EventArgs e)
        {
            FormAddEdtToRoomStudent formAddEdtToRoomStudent = new FormAddEdtToRoomStudent(1, studentId);
            formAddEdtToRoomStudent.ShowDialog();
            ToolStripMenuItemRefreshData_Click(sender, e);
        }

        private void ToolStripMenuItemDeleteStudentRoom_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connecton = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@Action", -1);
                    parameters.Add("@StudentId", studentId);
                    parameters.Add("@RoomId", 0);
                    parameters.Add("@DateSettlement", DateTime.Now);
                    parameters.Add("@LineAnswer", "", dbType: DbType.String, direction: ParameterDirection.Output);
                    connecton.Execute("up_upd_AddEditDeleteStudentRoom", parameters, commandType: CommandType.StoredProcedure);
                    if (parameters.Get<string>("@LineAnswer").Length > 0)
                    {
                        MessageBox.Show(parameters.Get<string>("@LineAnswer").ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    MessageBox.Show("Студент выселен из комнаты", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ToolStripMenuItemRefreshData_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItemShowAllInfo_Click(object sender, EventArgs e)
        {
            FormInformation formInformation = new FormInformation();
            formInformation.ShowDialog();
            ToolStripMenuItemRefreshData_Click(sender, e);
        }

        private void ToolStripMenuItemSaveCardStudentXLSX_Click(object sender, EventArgs e) => DownloadCardStudent(2);

        private void ToolStripMenuItemSaveAllCardStudentXLSX_ClickAsync(object sender, EventArgs e) => AllDownloadFile(2);

        private void ToolStripMenuItemSaveCardStudentPDF_Click(object sender, EventArgs e) => DownloadCardStudent(3);

        private void ToolStripMenuItemSaveAllCardStudentPDF_Click(object sender, EventArgs e) => AllDownloadFile(3);

        private void ToolStripMenuItemSaveCardStudentDOCX_Click(object sender, EventArgs e) => DownloadCardStudent(1);

        private void ToolStripMenuItemSaveAllCardStudentDOCX_Click(object sender, EventArgs e) => AllDownloadFile(1);

        private void StripMenuItemSaveCardStudentPPTX_Click(object sender, EventArgs e) => DownloadCardStudent(4);

        private void ToolStripMenuItemSaveAllCardStudentPPTX_Click(object sender, EventArgs e) => AllDownloadFile(4);

        private void DownloadCardStudent(int indexFileFormat)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    PortalCorporate.DownloadCardStudent(studentId, indexFileFormat, fbd.SelectedPath);
                }
            }
        }

        private void AllDownloadFile(int indexNumberFormat)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
                    {
                        var queryStudent = connection.Query("up_sel_InfoStudent", commandType: CommandType.StoredProcedure);
                        int[] dataStudent = (from p in queryStudent
                                             select (int)(p.StudentId)).ToArray();
                        Task.Run(() => PortalCorporate.DownloadAsyncCardStudent(dataStudent, indexNumberFormat, fbd.SelectedPath));
                    }
                }
            }       
        }

        private void ToolStripMenuItemSendMail_Click(object sender, EventArgs e)
        {
            FormSendMail formSendMail = new FormSendMail(studentId);
            formSendMail.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PortalCorporate.OpenCardStudentOnWebPortal(studentId);
        }

        private void ToolStripMenuItemShowCardStudentOnWebPortal_Click(object sender, EventArgs e) => PortalCorporate.OpenCardStudentOnWebPortal(studentId);

        private void ToolStripMenuItemShowListStudentOnWebPortal_Click(object sender, EventArgs e) => PortalCorporate.OpenInfoStudentOnWebPortal();
      
    }
}
