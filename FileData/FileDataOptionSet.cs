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
            Add("v|version", "Display Version of the file specified", v => _showVersion = true);
            Add("s|size", "Display Size of the file specified", s => _showSize = true);
        }

        protected override bool Parse(string argument, OptionContext c)
        {
            if (argument.Length < 3 || argument.StartsWith("--"))
            {
                return base.Parse(argument, c);
            }
            return false;
        }
    }
}
