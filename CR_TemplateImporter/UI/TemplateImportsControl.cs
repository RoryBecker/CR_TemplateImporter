using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CR_TemplateImporter.UI
{
    public partial class TemplateImportsControl : UserControl
    {
        public TemplateImportsControl()
        {
            InitializeComponent();
        }

        private void cmdImportTemplateUrl_Click(object sender, EventArgs e)
        {
            TemplateLoader TemplateLoader = new TemplateLoader();
            TemplateLoader.ImportTemplateViaUrl(txtTemplateFileUrl.Text);
            TemplateLoader.SaveAndReloadTemplates();
        }

        private void cmdImportPackageUrl_Click(object sender, EventArgs e)
        {
            TemplateLoader TemplateLoader = new TemplateLoader();
            TemplateLoader.ImportTemplatePackageViaUrl(txtPackageFileUrl.Text);
            TemplateLoader.SaveAndReloadTemplates();
        }

        private void cmdImportPackageRaw_Click(object sender, EventArgs e)
        {
            TemplateLoader TemplateLoader = new TemplateLoader();
            TemplateLoader.ImportTemplatePackageRaw(txtPackageFileUrl.Text);
            TemplateLoader.SaveAndReloadTemplates();
        }
    }
}
