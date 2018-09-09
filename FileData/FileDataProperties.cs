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
        private IFileDetails _fileDetails;

        public FileDataProperties(string filePath) : this(filePath, new FileDetailsAdapter())
        {            
        }

        public FileDataProperties(string filePath, IFileDetails fileDetails)
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
            _fileDetails = fileDetails ?? throw new ArgumentNullException(nameof(fileDetails));
        }

        private static bool IsValidFileName(string fileName)
        {
            return fileName.IndexOfAny(Path.GetInvalidFileNameChars()) == -1;
        }

        public int Size()
        {
            return _fileDetails.Size(_filePath);
        }

        public string Version()
        {
            return _fileDetails.Version(_filePath);
        }
    }
}
