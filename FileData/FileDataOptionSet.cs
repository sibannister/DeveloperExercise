using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NDesk.Options;

namespace FileData
{
    public class FileDataOptionSet : OptionSet
    {
        private bool _showVersion = false;
        private bool _showSize = false;

        public FileDataOptionSet()
        {
            Add("v", "Display Version of the file specified", v => _showVersion = true);
            Add("s", "Display Size of the file specified", s => _showSize = true);
        }
    }
}
