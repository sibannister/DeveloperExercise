using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class FileDataProperties
    {
        private readonly string _filePath;

        public FileDataProperties(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("filePath cannot be null, empty or only whitespaces");
            }

            if (!IsValidFileName(Path.GetFileName(filePath)))
            {
                throw new ArgumentException("file name cannot contain any of the following values: " + new string(Path.GetInvalidFileNameChars()));
            }

            _filePath = filePath;
        }

        private static bool IsValidFileName(string fileName)
        {
            return fileName.IndexOfAny(Path.GetInvalidFileNameChars()) == -1;
        }
    }
}
