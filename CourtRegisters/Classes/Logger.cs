using System.Collections;
using System.IO;
using System.Text;
using System.Web;

namespace System
{
    public static class Logger
    {
        static readonly string logPath = Directory.GetCurrentDirectory();

        public static void LogException(this Exception exception)
        {
            try
            {
                StringBuilder sbError = new StringBuilder();
                sbError.AppendLine();
                sbError.AppendLine("********");
                sbError.AppendLine();
                sbError.AppendFormat("{0} Error Caught in Application_Error event", DateTime.UtcNow);
                sbError.AppendLine();

                string host = string.Empty;

                sbError.AppendLine("Exceptions follow:");

                ProccessException(exception, sbError);

                sbError.AppendLine("********");
                Log(sbError.ToString());
            } // try
            catch
            {
            } // catch
        }

        private static void ProccessException(Exception objErr, StringBuilder sbError)
        {
            try
            {
                int i = 1;
                while (objErr != null)
                {
                    sbError.AppendFormat("{0} >>>>>>>>", i++);
                    sbError.AppendLine();
                    sbError.AppendLine();
                    sbError.AppendFormat("Exception type: {0}", objErr.GetType());
                    sbError.AppendLine();
                    sbError.AppendFormat("Error Message: {0}", objErr.Message);
                    sbError.AppendLine();
                    sbError.AppendFormat("Stack Trace: {0}", objErr.StackTrace);
                    sbError.AppendLine();

                    objErr = objErr.InnerException;
                } // while
            } // try
            catch
            {
            } // catch
        }

        public static void Log(string format, params object[] args)
        {
            try
            {
                string log = string.Format("{0:yyyy.MM.dd HH:mm.ss} - {1}{2}", DateTime.UtcNow, string.Format(format, args), Environment.NewLine);
                string sLogFile = logPath + string.Format("{0:yyyy-MM-dd}.LOG", DateTime.Today);
                if (File.Exists(sLogFile))
                    File.AppendAllText(sLogFile, log);
                else
                    File.WriteAllText(sLogFile, log);
            } // try
            catch
            {
            } // catch
        }

        public static void LogCollection(IEnumerable collection)
        {
            //var frame = new StackFrame(0);
            //var method = frame.GetMethod();
            //var parameter = method.GetParameters()[0];
            int i = 0;
            string name = collection.GetType().Name;
            //Log("{0}({1})", parameter.Name, parameter.ParameterType);
            foreach (var item in collection)
            {
                Log("{0}[{1}] = {2}", name, i++, item);
            }
        }
    }
}