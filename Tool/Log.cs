using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public sealed class Log
    {
        private static Log _instace = null;
        private string _path;
        
        public static Log GetInstance(string path)
        {
            if (_instace == null)
            {
                _instace = new Log(path);
            }
            return _instace;
        }

        private Log(string path)
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
