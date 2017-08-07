using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;
using AzureConfigManager.Models;

namespace AzureConfigManager.Services
{
    public class CustomErrorsService
    {
        private readonly FtpSettings _ftpSettings;
        private readonly ICredentials _credentials;

        public CustomErrorsService(FtpSettings ftpSettings)
        {
            _ftpSettings = ftpSettings;
            _credentials = new NetworkCredential(ftpSettings.User, ftpSettings.Password);
        }

        public bool Get()
        {
            var config = Read();

            var systemWeb = SystemWeb(config);
            var customErrors = systemWeb.Element("customErrors");
            if (customErrors == null)
            {
                throw new Exception("customErrors element is not present!");
            }

            var customErrorsMode = customErrors.Attribute("mode").Value;

            switch (customErrorsMode)
            {
                case "On":
                    return true;
                case "Off":
                    return false;
                default:
                    throw new ArgumentException();
            }
        }

        private static XElement SystemWeb(string config)
        {
            var xml = XElement.Parse(config);
            return xml.Element("system.web");
        }

        public void Set(bool value)
        {
            var config = Read();
            switch (value)
            {
                case true:
                    config = config.Replace("<customErrors mode=\"Off\"", "<customErrors mode=\"On\"");
                    break;
                case false:
                    config = config.Replace("<customErrors mode=\"On\"", "<customErrors mode=\"Off\"");
                    break;
            }

            Write(config);

        }

        private string Read()
        {
            var request = (FtpWebRequest)WebRequest.Create($"ftp://{_ftpSettings.Host}/site/wwwroot/Web.config");
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.  
            request.Credentials = _credentials;

            var response = (FtpWebResponse)request.GetResponse();

            var responseStream = response.GetResponseStream();
            var reader = new StreamReader(responseStream);
            var config = reader.ReadToEnd();
            return config;
        }

        private void Write(string text)
        {
            var request = (FtpWebRequest)WebRequest.Create($"ftp://{_ftpSettings.Host}/site/wwwroot/Web.config");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = _credentials;

            var bytes = Encoding.UTF8.GetBytes(text);
            var requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();

            var response = (FtpWebResponse) request.GetResponse();

            response.Close();
        }
    }
}
