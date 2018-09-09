using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class FileDataContext
    {
        private readonly string[] _args;

        public FileDataContext(string[] args)
        {
            _args = args ?? throw new ArgumentNullException();
        }        
    }
}
