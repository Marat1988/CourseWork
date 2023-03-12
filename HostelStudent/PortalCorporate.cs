using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace HostelStudent
{
    public class PortalCorporate
    {
        public static void DownloadCardStudent(int studentId, int indexDocumentFormat, string saveРath)
        {
            string UrlPortal = $"http://laptop-fo5qin3i:4863/ReportServer/Pages/ReportViewer.aspx?%2fInformation%2fCardStudent&StudentId={studentId}";
            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials;
            try
            {
                string DocumentFormat = "";
                string DocumentFormatFilenameExtension = "";
                switch (indexDocumentFormat)
                {
                    case 1:
                        DocumentFormat = "WORDOPENXML";
                        DocumentFormatFilenameExtension = "docx";
                        break;
                    case 2:
                        DocumentFormat = "EXCELOPENXML";
                        DocumentFormatFilenameExtension = "xlsx";
                        break;
                    case 3:
                        DocumentFormat = "PDF";
                        DocumentFormatFilenameExtension = "pdf";
                        break;
                    default:
                        DocumentFormat = "PDF";
                        DocumentFormatFilenameExtension = "pdf";
                        break;
                }
                UrlPortal = UrlPortal + "&rs:Command=Render&rs:Format=" + DocumentFormat;
                string name = "Card student id " + studentId;
                wc.DownloadFile(UrlPortal, saveРath + "\\" + name + "." + DocumentFormatFilenameExtension);
                MessageBox.Show("Карточка студента сохранена по пути: " + saveРath + "\\" + name + "." + DocumentFormatFilenameExtension, "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                wc.Dispose();
            }
        }

        public static void OpenInfoStudentOnWebPortal()
        {
            Process.Start("http://laptop-fo5qin3i:4863/ReportServer/Pages/ReportViewer.aspx?%2fInformation%2fInfoStudents&rs:Command=Render");
        }

        public static void OpenCardStudentOnWebPortal(int studentId)
        {
            Process.Start($"http://laptop-fo5qin3i:4863/ReportServer/Pages/ReportViewer.aspx?%2fInformation%2fCardStudent&StudentId={studentId}");
        }

        public static async Task DownloadAsyncCardStudent(int[] arrStudentId, int indexDocumentFormat, string saveРath)
        {
            await Task.Run(() => 
            {
                WebClient wc = new WebClient();
                wc.Credentials = CredentialCache.DefaultCredentials;               
                for (int i = 0; i < arrStudentId.Length; i++)
                {
                    try
                    {
                        string UrlPortal = $"http://laptop-fo5qin3i:4863/ReportServer/Pages/ReportViewer.aspx?%2fInformation%2fCardStudent&StudentId={arrStudentId[i]}";
                        string DocumentFormat = "";
                        string DocumentFormatFilenameExtension = "";
                        switch (indexDocumentFormat)
                        {
                            case 1:
                                DocumentFormat = "WORDOPENXML";
                                DocumentFormatFilenameExtension = "docx";
                                break;
                            case 2:
                                DocumentFormat = "EXCELOPENXML";
                                DocumentFormatFilenameExtension = "xlsx";
                                break;
                            case 3:
                                DocumentFormat = "PDF";
                                DocumentFormatFilenameExtension = "pdf";
                                break;
                            default:
                                DocumentFormat = "PDF";
                                DocumentFormatFilenameExtension = "pdf";
                                break;
                        }
                        UrlPortal = UrlPortal + "&rs:Command=Render&rs:Format=" + DocumentFormat;
                        string name = "Card student id " + arrStudentId[i];
                        wc.DownloadFile(UrlPortal, saveРath + "\\" + name + "." + DocumentFormatFilenameExtension);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                wc.Dispose();
                MessageBox.Show("Скачивание файлов завершено.", "INFORMATION", MessageBoxButton.OK, MessageBoxImage.Information);
            });
            Console.WriteLine("Конец метода PrintAsync");
        }
    }
}
