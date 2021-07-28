﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Log
    {
        private readonly static Log _instace = new Log();
        private string _path = "log.txt";
        public static Log Instance
        {
            get
            {
                return _instace;
            }
        }

        private Log()
        {

        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
