using ExceptionsTutorial.MyExceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsTutorial
{
    public class Logger
    {
        const string LOG_FILE = "LOG.txt";

        public Logger()
        {
        }

        public void SaveExceptionToLog(MyOwnException ex)
        {
            string logLine = System.String.Format("ERRORCODE:{0} TIME:{1:G}: {2}",ex.ErrorCode, System.DateTime.Now, ex.Message);
            using (var sw = File.AppendText(LOG_FILE))
            {
                sw.WriteLine(logLine);
            }
        }

        public void SaveExceptionToLog(Exception ex)
        {
            var sw = File.AppendText(LOG_FILE); 
            try
            {
                string logLine = System.String.Format("ERROR TIME:{0:G}: {1}", System.DateTime.Now, ex.Message);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Dispose();
            }
        }
    }
}
