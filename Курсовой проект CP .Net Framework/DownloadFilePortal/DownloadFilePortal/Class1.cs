using System.Net;

namespace DownloadFilePortal
{
    //Пример
    //ExportReportToFormat("http://tbvm3:4568/ReportServer/Pages/ReportViewer.aspx?%2fTEST%2fINVOCE&Invoce=", "83656;83659;83691;83692;83706;83740;83849;83850;83851;83878;83880;83892;83910", 6, "Счет", "D:\\TEST\\");
    public class DownloadFile
    {
        public static bool ExportReportToFormat(string UrlPath, int indexDocumentFormat, string SaveРath)
        {
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
                        DocumentFormat = "WORD";
                        DocumentFormatFilenameExtension = "doc";
                        break;
                    case 3:
                        DocumentFormat = "EXCELOPENXML";
                        DocumentFormatFilenameExtension = "xlsx";
                        break;
                    case 4:
                        DocumentFormat = "EXCEL";
                        DocumentFormatFilenameExtension = "xls";
                        break;
                    case 5:
                        DocumentFormat = "PPTX";
                        DocumentFormatFilenameExtension = "pptx";
                        break;
                    case 6:
                        DocumentFormat = "PDF";
                        DocumentFormatFilenameExtension = "pdf";
                        break;
                    default:
                        DocumentFormat = "PDF";
                        DocumentFormatFilenameExtension = "pdf";
                        break;
                }
                UrlPath = UrlPath + "&rs:Command=Render&rs:Format=" + DocumentFormat;
                string name = "Card student" + "." + DocumentFormatFilenameExtension;
                wc.DownloadFile(UrlPath, SaveРath + name);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                wc.Dispose();
            }
        }
    }
}
