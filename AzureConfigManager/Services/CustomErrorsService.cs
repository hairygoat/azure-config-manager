using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AzureConfigManager.Models;

namespace AzureConfigManager.Services
{
    public class CustomErrorsService
    {
        private readonly FtpSettings _ftpSettings;

        public CustomErrorsService(FtpSettings ftpSettings)
        {
            _ftpSettings = ftpSettings;
        }

        public bool Get()
        {
            // Get the object used to communicate with the server.  
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{_ftpSettings.Host}/site/wwwroot/Web.config");
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.  
            request.Credentials = new NetworkCredential(_ftpSettings.User, _ftpSettings.Password);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            var config = reader.ReadToEnd();

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
            
        }
    }
}
