using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class FileDataProperties
    {
        public FileDataProperties(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("filePath cannot be null, empty or only whitespaces");
            }
        }
    }
}
