using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HostelStudent
{
    public partial class FormSendMail : Form
    {
        string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        private int studentId;
        public FormSendMail(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            comboBoxFileExtension.SelectedIndex = 0;
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxAddress.Text, pattern, RegexOptions.IgnoreCase))
            {
                try
                {
                    using (var connecton = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString))
                    {
                        DynamicParameters parameters = new DynamicParameters();
                        parameters.Add("@StudentId", studentId);
                        parameters.Add("@IndexDocumentFormat", comboBoxFileExtension.SelectedIndex + 1);
                        parameters.Add("@Address", textBoxAddress.Text);
                        parameters.Add("@MessageSubject", textBoxSubject.Text);
                        parameters.Add("@MessageBoby", textBoxMessageBody.Text);
                        parameters.Add("@LineAnswer", "", dbType: DbType.String, direction: ParameterDirection.Output);
                        connecton.Execute("up_sel_sendStudentCardEmail", parameters, commandType: CommandType.StoredProcedure);
                        if (parameters.Get<string>("@LineAnswer").Length > 0)
                        {
                            MessageBox.Show(parameters.Get<string>("@LineAnswer").ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        MessageBox.Show("Письмо отправлено!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не соответствие формата e-mail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
