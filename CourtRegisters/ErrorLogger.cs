using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace CourtRegisters
{
    public static class ErrorLogger
    {
        public static void LogError(Exception err)
        {
            string sMessage = err.StackTrace;// err.InnerException == null ? err.Message : err.InnerException.Message;

            string sFileName = string.Format("{0}/{1:yyyy-MM-dd}.LOG", Environment.CurrentDirectory, DateTime.Today);
            if (File.Exists(sFileName))
                File.AppendAllText(sFileName, sMessage);
            else
                File.WriteAllText(sFileName, sMessage);
        }
    }
}
