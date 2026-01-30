using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Employee_Management_Syatem.Utils
{
    public static class Logger
    {
        private static readonly string LogFile = "log.txt";
        public static void Log(string message)
        {
            File.AppendAllText(LogFile, $"{DateTime.Now}: {message} {Environment.NewLine}");
        }
    }
}
