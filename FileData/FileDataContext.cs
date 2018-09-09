using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class FileDataContext
    {
        public const string HelpMessage = "Please specify two arguments.\nExample:  -v <file_path>     - For the version of the file";

        private readonly string[] _args;
        private readonly FileDataOptionSet _fileDataOptionSet;

        public FileDataContext(string[] args) : this(args, new FileDataOptionSet())
        {            
        }

        public FileDataContext(string[] args, FileDataOptionSet fileDataOptionSet) : this(args, fileDataOptionSet, new FileDetailsAdapter())
        {            
        }

        public FileDataContext(string[] args, FileDataOptionSet fileDataOptionSet, IFileDetails fileDetails)
        {
            _args = args ?? throw new ArgumentNullException();
            _fileDataOptionSet = fileDataOptionSet ?? throw new ArgumentNullException();

            if (_args.Length != 2)
            {
                throw new ArgumentException("Must have two arguments");
            }

            FileDataProperties = new FileDataProperties(args[1], fileDetails);
        }

        public FileDataProperties FileDataProperties { get; }

        public void Write(TextWriter textWriter)
        {
            _fileDataOptionSet.Parse(new string[] { _args[0] });
            if (!_fileDataOptionSet.ShowVersion() && !_fileDataOptionSet.ShowSize())
            {
                WriteHelpMessage(textWriter);
            }
            else
            {
                WriteFileData(textWriter);
            }
        }

        private void WriteHelpMessage(TextWriter textWriter)
        {
            textWriter.WriteLine(HelpMessage);
            _fileDataOptionSet.WriteOptionDescriptions(textWriter);
        }

        private void WriteFileData(TextWriter textWriter)
        {
            if (_fileDataOptionSet.ShowVersion())
            {
                textWriter.Write(FileDataProperties.Version());
            }

            if (_fileDataOptionSet.ShowSize())
            {
                textWriter.Write(FileDataProperties.Size());
            }
        }
    }
}
