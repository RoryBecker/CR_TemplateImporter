using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CR_TemplateImporter
{
    public static class StringExtensions
    {
        public static Stream ToStream(this string TheString)
        {
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(TheString);
            return new MemoryStream(byteArray);
        }
    }
}
