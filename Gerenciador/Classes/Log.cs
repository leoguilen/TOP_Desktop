using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador.Classes
{
    public static class Log
    {
        private static readonly string CaminhoLog = Directory.GetCurrentDirectory() + @"\.log.txt";
        
        public static void GerarLog(string msg)
        {
            if(!File.Exists(CaminhoLog))
            {
                using (StreamWriter writeLog = File.CreateText(CaminhoLog))
                {
                    writeLog.WriteLine(DateTime.Now + " " + "Detalhes: " + msg + "\n");
                }
            } else
            {
                using (StreamWriter writeLog = File.AppendText(CaminhoLog))
                {
                    writeLog.WriteLine(DateTime.Now + " " + msg + "\n");
                }
            }
        }

        internal static void GerarLog(object p)
        {
            throw new NotImplementedException();
        }
    }
}
