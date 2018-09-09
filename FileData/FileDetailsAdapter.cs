using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class FileDetailsAdapter : IFileDetails
    {
        private static readonly FileDetails FileDetails = new FileDetails();

        public string Version(string filePath)
        {
            return FileDetails.Version(filePath);
        }

        public int Size(string filePath)
        {
            return FileDetails.Size(filePath);
        }
    }
}
