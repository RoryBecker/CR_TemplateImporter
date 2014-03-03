using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CR_TemplateImporter
{
    public static class StreamExtensions
    {
        public static string ReadAsString(this Stream Stream)
        {
            string Result;
            using (var Reader = new StreamReader(Stream))
            {
                Result = Reader.ReadToEnd();
                Reader.Close();
                return Result;
            }
        }
    }
}
