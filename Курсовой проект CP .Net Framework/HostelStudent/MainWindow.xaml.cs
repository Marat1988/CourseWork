using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace HostelStudent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connString;
        public MainWindow()
        {
            InitializeComponent();
            connString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }

        private void ButtonLogIn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("up_sel_checkPasswordUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = TextBoxUserName.Text;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = TextBoxUserPassword.Password;
                SqlParameter outParamLineAsnwer = new SqlParameter("@LineAnswer", SqlDbType.VarChar, 1000);
                SqlParameter outParamCheckPassword = new SqlParameter("@AuthenticationPassed", SqlDbType.Bit);

                outParamLineAsnwer.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParamLineAsnwer);

                outParamCheckPassword.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outParamCheckPassword);

                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@LineAnswer"].Value.ToString().Length > 0)
                {
                    System.Windows.MessageBox.Show(cmd.Parameters["@LineAnswer"].Value.ToString(), "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if ((bool)(cmd.Parameters["@AuthenticationPassed"].Value))
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Closed += (s, args) => this.Close();
                    mainForm.Show();
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                conn?.Close();
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
