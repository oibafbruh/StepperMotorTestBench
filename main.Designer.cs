
namespace SharpUpdate2
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.updateavailabletext = new System.Windows.Forms.Label();
            this.descriptionupdatetext = new System.Windows.Forms.Label();
            this.currentversiontext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentversion = new System.Windows.Forms.Label();
            this.newversion = new System.Windows.Forms.Label();
            this.arrowtext = new System.Windows.Forms.Label();
            this.versionskip = new System.Windows.Forms.Button();
            this.remindmebtn = new System.Windows.Forms.Button();
            this.installbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateavailabletext
            // 
            this.updateavailabletext.AutoSize = true;
            this.updateavailabletext.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateavailabletext.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updateavailabletext.Location = new System.Drawing.Point(205, 44);
            this.updateavailabletext.Name = "updateavailabletext";
            this.updateavailabletext.Size = new System.Drawing.Size(291, 32);
            this.updateavailabletext.TabIndex = 123;
            this.updateavailabletext.Text = "New Update is Available";
            this.updateavailabletext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionupdatetext
            // 
            this.descriptionupdatetext.AutoSize = true;
            this.descriptionupdatetext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionupdatetext.Location = new System.Drawing.Point(113, 92);
            this.descriptionupdatetext.Name = "descriptionupdatetext";
            this.descriptionupdatetext.Size = new System.Drawing.Size(474, 20);
            this.descriptionupdatetext.TabIndex = 1;
            this.descriptionupdatetext.Text = "A new version of the StepperMotorTestBench Control App is available!";
            this.descriptionupdatetext.Click += new System.EventHandler(this.descriptionupdatetext_Click);
            // 
            // currentversiontext
            // 
            this.currentversiontext.AutoSize = true;
            this.currentversiontext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentversiontext.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentversiontext.Location = new System.Drawing.Point(167, 152);
            this.currentversiontext.Name = "currentversiontext";
            this.currentversiontext.Size = new System.Drawing.Size(112, 20);
            this.currentversiontext.TabIndex = 2;
            this.currentversiontext.Text = "Current Version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Version:";
            // 
            // currentversion
            // 
            this.currentversion.AutoSize = true;
            this.currentversion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentversion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentversion.Location = new System.Drawing.Point(188, 172);
            this.currentversion.Name = "currentversion";
            this.currentversion.Size = new System.Drawing.Size(71, 32);
            this.currentversion.TabIndex = 4;
            this.currentversion.Text = "0.0.0";
            this.currentversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newversion
            // 
            this.newversion.AutoSize = true;
            this.newversion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newversion.Location = new System.Drawing.Point(440, 172);
            this.newversion.Name = "newversion";
            this.newversion.Size = new System.Drawing.Size(71, 32);
            this.newversion.TabIndex = 5;
            this.newversion.Text = "0.0.0";
            this.newversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrowtext
            // 
            this.arrowtext.AutoSize = true;
            this.arrowtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowtext.Location = new System.Drawing.Point(311, 139);
            this.arrowtext.Name = "arrowtext";
            this.arrowtext.Size = new System.Drawing.Size(79, 73);
            this.arrowtext.TabIndex = 6;
            this.arrowtext.Text = "🠒";
            // 
            // versionskip
            // 
            this.versionskip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.versionskip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionskip.Location = new System.Drawing.Point(13, 266);
            this.versionskip.Name = "versionskip";
            this.versionskip.Size = new System.Drawing.Size(154, 33);
            this.versionskip.TabIndex = 2;
            this.versionskip.TabStop = false;
            this.versionskip.Text = "SKIP THIS VERSION";
            this.versionskip.UseVisualStyleBackColor = true;
            this.versionskip.Click += new System.EventHandler(this.versionskip_Click);
            // 
            // remindmebtn
            // 
            this.remindmebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.remindmebtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remindmebtn.Location = new System.Drawing.Point(359, 266);
            this.remindmebtn.Name = "remindmebtn";
            this.remindmebtn.Size = new System.Drawing.Size(156, 33);
            this.remindmebtn.TabIndex = 3;
            this.remindmebtn.TabStop = false;
            this.remindmebtn.Text = "REMIND ME LATER";
            this.remindmebtn.UseVisualStyleBackColor = true;
            this.remindmebtn.Click += new System.EventHandler(this.remindmebtn_Click);
            // 
            // installbtn
            // 
            this.installbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.installbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.installbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.installbtn.Location = new System.Drawing.Point(521, 266);
            this.installbtn.Name = "installbtn";
            this.installbtn.Size = new System.Drawing.Size(151, 33);
            this.installbtn.TabIndex = 1;
            this.installbtn.TabStop = false;
            this.installbtn.Text = "INSTALL UPDATE";
            this.installbtn.UseVisualStyleBackColor = false;
            this.installbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.installbtn);
            this.Controls.Add(this.remindmebtn);
            this.Controls.Add(this.versionskip);
            this.Controls.Add(this.arrowtext);
            this.Controls.Add(this.newversion);
            this.Controls.Add(this.currentversion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentversiontext);
            this.Controls.Add(this.descriptionupdatetext);
            this.Controls.Add(this.updateavailabletext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpUpdate 2.9.43";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateavailabletext;
        private System.Windows.Forms.Label descriptionupdatetext;
        private System.Windows.Forms.Label currentversiontext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentversion;
        private System.Windows.Forms.Label newversion;
        private System.Windows.Forms.Label arrowtext;
        private System.Windows.Forms.Button versionskip;
        private System.Windows.Forms.Button remindmebtn;
        private System.Windows.Forms.Button installbtn;
    }
}

