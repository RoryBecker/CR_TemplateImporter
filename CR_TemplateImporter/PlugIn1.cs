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
using CR_TemplateImporter.UI;

namespace CR_TemplateImporter
{
    public partial class PlugIn1 : StandardPlugIn
    {
        // DXCore-generated code...
        #region InitializePlugIn
        public override void InitializePlugIn()
        {
            base.InitializePlugIn();
            registerImportTemplates();
            //
            // TODO: Add your initialization code here.
            //
        }
        #endregion
        #region FinalizePlugIn
        public override void FinalizePlugIn()
        {
            //
            // TODO: Add your finalization code here.
            //

            base.FinalizePlugIn();
        }
        #endregion

        public void registerImportTemplates()
        {
            DevExpress.CodeRush.Core.Action ImportTemplates = new DevExpress.CodeRush.Core.Action(components);
            ((System.ComponentModel.ISupportInitialize)(ImportTemplates)).BeginInit();
            ImportTemplates.ActionName = "ImportTemplates";
            ImportTemplates.ButtonText = "Import Templates"; // Used if button is placed on a menu.
            ImportTemplates.RegisterInCR = true;
            ImportTemplates.Execute += ImportTemplates_Execute;
            ImportTemplates.CommonMenu = DevExpress.CodeRush.Menus.VsCommonBar.DevExpress;
            ((System.ComponentModel.ISupportInitialize)(ImportTemplates)).EndInit();
        }
        private void ImportTemplates_Execute(ExecuteEventArgs ea)
        {

            // Package: https://raw2.github.com/RoryBecker/CodeRushTemplatePackages/master/CS_PluginTemplatesPackage.xml
            // Template: https://raw2.github.com/RoryBecker/CodeRushPluginTemplates/master/CS_NewAction.xml
            // Template: https://raw2.github.com/groovyghoul/fakeiteasy-coderush-templates/master/CSharp_Custom_FakeItEasy.xml
            //TemplateLoader TemplateLoader = new TemplateLoader();
            //TemplateLoader.ImportTemplatePackageViaUrl("https://raw2.github.com/RoryBecker/CodeRushTemplatePackages/master/CS_PluginTemplatesPackage.xml");
            //TemplateLoader.SaveAndReloadTemplates();
            using (TemplateImporter TemplateImporter = new TemplateImporter())
            {
                TemplateImporter.ShowDialog();
            }

        }

    }
}