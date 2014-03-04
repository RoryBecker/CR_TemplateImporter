using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CR_TemplateImporter.UI
{
    public partial class TemplateImporter : Form
    {
        public TemplateImporter()
        {
            InitializeComponent();
        }

        private void cmdImportTemplateUrl_Click(object sender, EventArgs e)
        {
            Cursor saveCursor = Cursor.Current;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                TemplateLoader TemplateLoader = new TemplateLoader();
                TemplateLoader.ImportTemplateViaUrl(txtTemplateFileUrl.Text);
                TemplateLoader.SaveAndReloadTemplates();
                System.Windows.Forms.MessageBox.Show("Templates Imported");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = saveCursor;
            }
        }

        private void cmdImportPackageUrl_Click(object sender, EventArgs e)
        {
            Cursor saveCursor = Cursor.Current;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                TemplateLoader TemplateLoader = new TemplateLoader();
                TemplateLoader.ImportTemplatePackageViaUrl(txtPackageFileUrl.Text);
                TemplateLoader.SaveAndReloadTemplates();
                System.Windows.Forms.MessageBox.Show("Package Imported");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = saveCursor;
            }
        }

        private void cmdCopyTemplateExample_Click(object sender, EventArgs e)
        {
            txtTemplateFileUrl.Text = "https://raw2.github.com/RoryBecker/CodeRushPluginTemplates/master/CS_NewAction.xml";
        }

        private void cmdCopyPackageExample_Click(object sender, EventArgs e)
        {
            txtPackageFileUrl.Text = "https://raw2.github.com/RoryBecker/CodeRushTemplatePackages/master/CS_PluginTemplatesPackage.xml";
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
