namespace CR_TemplateImporter.UI
{
    partial class TemplateImporter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageFileUrl = new System.Windows.Forms.TextBox();
            this.txtTemplateFileUrl = new System.Windows.Forms.TextBox();
            this.cmdImportPackageUrl = new System.Windows.Forms.Button();
            this.cmdImportTemplateUrl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdCopyTemplateExample = new System.Windows.Forms.Button();
            this.cmdCopyPackageExample = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(546, 166);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Package Url - Url to Package file (XML list of resources - ie on the web again :)" +
    "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Template Url - Url to Exported Template file  (ie Somewhere on the web - Like Git" +
    "hub :)";
            // 
            // txtPackageFileUrl
            // 
            this.txtPackageFileUrl.Location = new System.Drawing.Point(15, 93);
            this.txtPackageFileUrl.Name = "txtPackageFileUrl";
            this.txtPackageFileUrl.Size = new System.Drawing.Size(525, 20);
            this.txtPackageFileUrl.TabIndex = 18;
            // 
            // txtTemplateFileUrl
            // 
            this.txtTemplateFileUrl.Location = new System.Drawing.Point(15, 25);
            this.txtTemplateFileUrl.Name = "txtTemplateFileUrl";
            this.txtTemplateFileUrl.Size = new System.Drawing.Size(525, 20);
            this.txtTemplateFileUrl.TabIndex = 17;
            // 
            // cmdImportPackageUrl
            // 
            this.cmdImportPackageUrl.Location = new System.Drawing.Point(546, 91);
            this.cmdImportPackageUrl.Name = "cmdImportPackageUrl";
            this.cmdImportPackageUrl.Size = new System.Drawing.Size(75, 23);
            this.cmdImportPackageUrl.TabIndex = 15;
            this.cmdImportPackageUrl.Text = "Import";
            this.cmdImportPackageUrl.UseVisualStyleBackColor = true;
            this.cmdImportPackageUrl.Click += new System.EventHandler(this.cmdImportPackageUrl_Click);
            // 
            // cmdImportTemplateUrl
            // 
            this.cmdImportTemplateUrl.Location = new System.Drawing.Point(546, 23);
            this.cmdImportTemplateUrl.Name = "cmdImportTemplateUrl";
            this.cmdImportTemplateUrl.Size = new System.Drawing.Size(75, 23);
            this.cmdImportTemplateUrl.TabIndex = 16;
            this.cmdImportTemplateUrl.Text = "Import";
            this.cmdImportTemplateUrl.UseVisualStyleBackColor = true;
            this.cmdImportTemplateUrl.Click += new System.EventHandler(this.cmdImportTemplateUrl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(495, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Example - https://raw2.github.com/RoryBecker/CodeRushPluginTemplates/master/CS_Ne" +
    "wAction.xml";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(578, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Example - https://raw2.github.com/RoryBecker/CodeRushTemplatePackages/master/CS_P" +
    "luginTemplatesPackage.xml";
            // 
            // cmdCopyTemplateExample
            // 
            this.cmdCopyTemplateExample.Location = new System.Drawing.Point(2, 23);
            this.cmdCopyTemplateExample.Name = "cmdCopyTemplateExample";
            this.cmdCopyTemplateExample.Size = new System.Drawing.Size(16, 23);
            this.cmdCopyTemplateExample.TabIndex = 24;
            this.cmdCopyTemplateExample.Text = ">";
            this.cmdCopyTemplateExample.UseVisualStyleBackColor = true;
            this.cmdCopyTemplateExample.Click += new System.EventHandler(this.cmdCopyTemplateExample_Click);
            // 
            // cmdCopyPackageExample
            // 
            this.cmdCopyPackageExample.Location = new System.Drawing.Point(2, 91);
            this.cmdCopyPackageExample.Name = "cmdCopyPackageExample";
            this.cmdCopyPackageExample.Size = new System.Drawing.Size(16, 23);
            this.cmdCopyPackageExample.TabIndex = 24;
            this.cmdCopyPackageExample.Text = ">";
            this.cmdCopyPackageExample.UseVisualStyleBackColor = true;
            this.cmdCopyPackageExample.Click += new System.EventHandler(this.cmdCopyPackageExample_Click);
            // 
            // TemplateImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 198);
            this.Controls.Add(this.cmdCopyPackageExample);
            this.Controls.Add(this.cmdCopyTemplateExample);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPackageFileUrl);
            this.Controls.Add(this.txtTemplateFileUrl);
            this.Controls.Add(this.cmdImportPackageUrl);
            this.Controls.Add(this.cmdImportTemplateUrl);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TemplateImporter";
            this.Text = "Template Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackageFileUrl;
        private System.Windows.Forms.TextBox txtTemplateFileUrl;
        private System.Windows.Forms.Button cmdImportPackageUrl;
        private System.Windows.Forms.Button cmdImportTemplateUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdCopyTemplateExample;
        private System.Windows.Forms.Button cmdCopyPackageExample;
    }
}