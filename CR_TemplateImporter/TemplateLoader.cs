using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;
using DevExpress.CodeRush.Core;
namespace CR_TemplateImporter
{
    public class TemplateLoader
    {

        public void ImportTemplatePackageViaUrl(string PackageUrl) 
        {
            var PackageAsString = Web.GetUrlContentAsString(PackageUrl);
            ImportTemplatePackageRaw(PackageAsString);
        }
        public void ImportTemplatePackageRaw(string PackageAsString)
        {
            //<root>
            //    <templates>
            //        <template url="asdasdasd" language="csharp" />
            //    </templates>
            //</root>  
            
            var XML = XElement.Parse(PackageAsString);

            XElement TemplatesParent = XML.Elements("templates").FirstOrDefault();
            foreach (XElement template in TemplatesParent.Elements("template"))
            {
                ImportTemplateViaUrl(template.Attribute("url").Value, template.Attribute("language").Value);
            }
        }

        public void ImportTemplateViaUrl(string ImportUrl)
        {
            ImportTemplateViaUrl(ImportUrl, GuessLanguage(ImportUrl));
        }
        public void ImportTemplateViaUrl(string ImportUrl, string Language)
        {
            TemplateCategory ImportCategory = LoadTemplateCategoryFromUrl(ImportUrl);
            TemplateCategory RootCategory = (from TemplateCategory Cat in CodeRush.Templates.GetCategories(Language)
                                             where Cat.Name == ImportCategory.Name
                                             select Cat).FirstOrDefault();
            DuplicateCategoryContent(ImportCategory, RootCategory);
        }
        private static string GuessLanguage(string ImportUrl)
        {

            // guess language
            string filename = new Uri(ImportUrl).Segments.Last().ToLower();
            if (filename.StartsWith("cs_") || filename.StartsWith("csharp"))
            {
                return "CSharp";
            }
            if (filename.StartsWith("vb_") || filename.StartsWith("<Bold>B</Bold>asic"))
            {
                return "Basic";
            }
            return "";
        }

        private TemplateCategory LoadTemplateCategoryFromUrl(String Url)
        {
            var TemplateAsString = Web.GetUrlContentAsString(Url);
            var CategoryCollection = (new ObjectSerializer()).LoadFromString(TemplateAsString);
            var Category = CategoryCollection as TemplateCategory;
            if (Category != null)
            {
                return Category;
            }
            Category = (CategoryCollection as TemplateCategoryCollection)[0];
            return Category;
        }
        private void DuplicateCategoryContent(TemplateCategory SourceCategory, TemplateCategory DestCategory)
        {
            foreach (TemplateCategory SourceChildCategory in SourceCategory.Categories)
            {
                var DestChildCategory = (from TemplateCategory cat in DestCategory.Categories
                                         where cat.Name == SourceChildCategory.Name
                                         select cat).FirstOrDefault();
                if (DestChildCategory == null)
                {
                    DestChildCategory = new TemplateCategory();
                    DestChildCategory.Name = SourceChildCategory.Name;
                    DestCategory.Categories.Add(DestChildCategory);
                }
                DuplicateCategoryContent(SourceChildCategory, DestChildCategory);
            }
            CopyTemplatesBetweenCategories(SourceCategory, DestCategory);
        }
        private void CopyTemplatesBetweenCategories(TemplateCategory SourceCategory, TemplateCategory DestCategory)
        {
            foreach (Template SourceTemplate in SourceCategory.Templates)
            {
                var DestTemplate = (from Template temp in DestCategory.Templates
                                    where temp.Name == SourceTemplate.Name
                                    select temp).FirstOrDefault();
                if (DestTemplate != null)
                {
                    DestCategory.Templates.Remove(DestTemplate);
                }
                DestCategory.Templates.Add(SourceTemplate);

            }
        }
        public void SaveAndReloadTemplates()
        {
            CodeRush.Templates.Save();
            CodeRush.Templates.Reload();
        }
    }
}
