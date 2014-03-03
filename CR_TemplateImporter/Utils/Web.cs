using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.CodeRush.Core;
using DevExpress.CodeRush.PlugInCore;
using DevExpress.CodeRush.StructuralParser;
using System.Xml.Linq;
using System.Net;
using System.IO;

namespace CR_TemplateImporter
{
    public class Web
    {
        public static XElement GetUrlContentAsXElement(String Url)
        {
            return XElement.Parse(GetUrlContentAsString(Url));
        }
        public static String GetUrlContentAsString(String Url)
        {
            WebRequest Request = WebRequest.Create(Url);
            WebResponse Response = Request.GetResponse();
            using (StreamReader Reader = new StreamReader(Response.GetResponseStream()))
            {
                return Reader.ReadToEnd();
            }
        }
    }
}
