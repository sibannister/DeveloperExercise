using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var fileDataContext = new FileDataContext(args);
            fileDataContext.Write(Console.Out);
        }
    }
}
