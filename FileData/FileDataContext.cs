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
        private readonly FileDataOptionSet _fileDataOptionSet;

        public FileDataContext(string[] args) : this(args, new FileDataOptionSet())
        {            
        }

        public FileDataContext(string[] args, FileDataOptionSet fileDataOptionSet)
        {
            _args = args ?? throw new ArgumentNullException();
            _fileDataOptionSet = fileDataOptionSet ?? throw new ArgumentNullException();

            if (_args.Length != 2)
            {
                throw new ArgumentException("Must have two arguments");
            }
        }
    }
}
