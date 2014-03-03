using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Soap;

namespace CR_TemplateImporter
{
    public class ObjectSerializer
    {

        private SoapFormatter GetFormatter()
        {
            return new SoapFormatter() { AssemblyFormat = FormatterAssemblyStyle.Simple };
        }
        public object LoadFromString(string XML)
        {
            return LoadFromStream(XML.ToStream());

        }
        public object LoadFromStream(Stream stream)
        {
            return GetFormatter().Deserialize(stream);
        }
        public string SaveToString(Object Obj)
        {
            return SaveToStream(Obj, new MemoryStream()).ReadAsString();
        }
        public Stream SaveToStream(Object Obj, MemoryStream Stream)
        {
            GetFormatter().Serialize(Stream, Obj);
            return Stream;
        }
    }
}
