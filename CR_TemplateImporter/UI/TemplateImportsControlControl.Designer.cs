namespace CR_TemplateImporter.UI
{
    partial class TemplateImportsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateImportsControl));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPackageFileUrl = new System.Windows.Forms.TextBox();
            this.txtPackageFileRaw = new System.Windows.Forms.TextBox();
            this.txtTemplateFileUrl = new System.Windows.Forms.TextBox();
            this.cmdImportPackageRaw = new System.Windows.Forms.Button();
            this.cmdImportPackageUrl = new System.Windows.Forms.Button();
            this.cmdImportTemplateUrl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Package File Raw - raw package file. Example given";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Package File Url - Url to Package file (XML list of resources - ie on the web aga" +
    "in :)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Template File Url - Url to Exported Template file  (ie Somewhere on the web - Lik" +
    "e Github :)";
            // 
            // txtPackageFileUrl
            // 
            this.txtPackageFileUrl.Location = new System.Drawing.Point(6, 63);
            this.txtPackageFileUrl.Name = "txtPackageFileUrl";
            this.txtPackageFileUrl.Size = new System.Drawing.Size(414, 20);
            this.txtPackageFileUrl.TabIndex = 9;
            // 
            // txtPackageFileRaw
            // 
            this.txtPackageFileRaw.Location = new System.Drawing.Point(6, 101);
            this.txtPackageFileRaw.Multiline = true;
            this.txtPackageFileRaw.Name = "txtPackageFileRaw";
            this.txtPackageFileRaw.Size = new System.Drawing.Size(414, 145);
            this.txtPackageFileRaw.TabIndex = 10;
            this.txtPackageFileRaw.Text = resources.GetString("txtPackageFileRaw.Text");
            this.txtPackageFileRaw.WordWrap = false;
            // 
            // txtTemplateFileUrl
            // 
            this.txtTemplateFileUrl.Location = new System.Drawing.Point(6, 25);
            this.txtTemplateFileUrl.Name = "txtTemplateFileUrl";
            this.txtTemplateFileUrl.Size = new System.Drawing.Size(414, 20);
            this.txtTemplateFileUrl.TabIndex = 8;
            // 
            // cmdImportPackageRaw
            // 
            this.cmdImportPackageRaw.Location = new System.Drawing.Point(426, 223);
            this.cmdImportPackageRaw.Name = "cmdImportPackageRaw";
            this.cmdImportPackageRaw.Size = new System.Drawing.Size(75, 23);
            this.cmdImportPackageRaw.TabIndex = 5;
            this.cmdImportPackageRaw.Text = "Import";
            this.cmdImportPackageRaw.UseVisualStyleBackColor = true;
            this.cmdImportPackageRaw.Click += new System.EventHandler(this.cmdImportPackageRaw_Click);
            // 
            // cmdImportPackageUrl
            // 
            this.cmdImportPackageUrl.Location = new System.Drawing.Point(426, 61);
            this.cmdImportPackageUrl.Name = "cmdImportPackageUrl";
            this.cmdImportPackageUrl.Size = new System.Drawing.Size(75, 23);
            this.cmdImportPackageUrl.TabIndex = 6;
            this.cmdImportPackageUrl.Text = "Import";
            this.cmdImportPackageUrl.UseVisualStyleBackColor = true;
            this.cmdImportPackageUrl.Click += new System.EventHandler(this.cmdImportPackageUrl_Click);
            // 
            // cmdImportTemplateUrl
            // 
            this.cmdImportTemplateUrl.Location = new System.Drawing.Point(426, 23);
            this.cmdImportTemplateUrl.Name = "cmdImportTemplateUrl";
            this.cmdImportTemplateUrl.Size = new System.Drawing.Size(75, 23);
            this.cmdImportTemplateUrl.TabIndex = 7;
            this.cmdImportTemplateUrl.Text = "Import";
            this.cmdImportTemplateUrl.UseVisualStyleBackColor = true;
            this.cmdImportTemplateUrl.Click += new System.EventHandler(this.cmdImportTemplateUrl_Click);
            // 
            // TemplateImportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPackageFileUrl);
            this.Controls.Add(this.txtPackageFileRaw);
            this.Controls.Add(this.txtTemplateFileUrl);
            this.Controls.Add(this.cmdImportPackageRaw);
            this.Controls.Add(this.cmdImportPackageUrl);
            this.Controls.Add(this.cmdImportTemplateUrl);
            this.Name = "TemplateImportsControl";
            this.Size = new System.Drawing.Size(508, 331);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPackageFileUrl;
        private System.Windows.Forms.TextBox txtPackageFileRaw;
        private System.Windows.Forms.TextBox txtTemplateFileUrl;
        private System.Windows.Forms.Button cmdImportPackageRaw;
        private System.Windows.Forms.Button cmdImportPackageUrl;
        private System.Windows.Forms.Button cmdImportTemplateUrl;
    }
}
