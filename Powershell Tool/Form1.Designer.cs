namespace Powershell_Tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tControl_Main = new System.Windows.Forms.TabControl();
            this.tPage_PSOU = new System.Windows.Forms.TabPage();
            this.lbl_OUBase = new System.Windows.Forms.Label();
            this.tBox_OUBase = new System.Windows.Forms.TextBox();
            this.btn_CreateOU = new System.Windows.Forms.Button();
            this.tbox_OUName = new System.Windows.Forms.TextBox();
            this.chBox_PFAD = new System.Windows.Forms.CheckBox();
            this.lbl_OUName = new System.Windows.Forms.Label();
            this.tPage_PSUser = new System.Windows.Forms.TabPage();
            this.tPage_PSGroup = new System.Windows.Forms.TabPage();
            this.tBox_DN = new System.Windows.Forms.TextBox();
            this.tBox_TLD = new System.Windows.Forms.TextBox();
            this.lbl_DN = new System.Windows.Forms.Label();
            this.lbl_TLD = new System.Windows.Forms.Label();
            this.btn_SaveDNTLD = new System.Windows.Forms.Button();
            this.btn_ReadDNTLD = new System.Windows.Forms.Button();
            this.cBox_TLD = new System.Windows.Forms.ComboBox();
            this.cBox_DN = new System.Windows.Forms.ComboBox();
            this.lbl_STLD = new System.Windows.Forms.Label();
            this.lbl_SDN = new System.Windows.Forms.Label();
            this.tControl_Main.SuspendLayout();
            this.tPage_PSOU.SuspendLayout();
            this.SuspendLayout();
            // 
            // tControl_Main
            // 
            this.tControl_Main.Controls.Add(this.tPage_PSOU);
            this.tControl_Main.Controls.Add(this.tPage_PSUser);
            this.tControl_Main.Controls.Add(this.tPage_PSGroup);
            this.tControl_Main.Location = new System.Drawing.Point(12, 12);
            this.tControl_Main.Name = "tControl_Main";
            this.tControl_Main.SelectedIndex = 0;
            this.tControl_Main.Size = new System.Drawing.Size(798, 567);
            this.tControl_Main.TabIndex = 0;
            this.tControl_Main.TabStop = false;
            // 
            // tPage_PSOU
            // 
            this.tPage_PSOU.BackColor = System.Drawing.Color.Transparent;
            this.tPage_PSOU.Controls.Add(this.lbl_OUBase);
            this.tPage_PSOU.Controls.Add(this.tBox_OUBase);
            this.tPage_PSOU.Controls.Add(this.btn_CreateOU);
            this.tPage_PSOU.Controls.Add(this.tbox_OUName);
            this.tPage_PSOU.Controls.Add(this.chBox_PFAD);
            this.tPage_PSOU.Controls.Add(this.lbl_OUName);
            this.tPage_PSOU.Location = new System.Drawing.Point(4, 22);
            this.tPage_PSOU.Name = "tPage_PSOU";
            this.tPage_PSOU.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_PSOU.Size = new System.Drawing.Size(790, 541);
            this.tPage_PSOU.TabIndex = 0;
            this.tPage_PSOU.Text = "PowerShell OU";
            // 
            // lbl_OUBase
            // 
            this.lbl_OUBase.AutoSize = true;
            this.lbl_OUBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OUBase.Location = new System.Drawing.Point(297, 11);
            this.lbl_OUBase.Name = "lbl_OUBase";
            this.lbl_OUBase.Size = new System.Drawing.Size(430, 17);
            this.lbl_OUBase.TabIndex = 14;
            this.lbl_OUBase.Text = "Übergeordnete Organisationseinheit (OU / OU.ÜberOU.ÜberOU...)";
            // 
            // tBox_OUBase
            // 
            this.tBox_OUBase.Location = new System.Drawing.Point(300, 34);
            this.tBox_OUBase.Name = "tBox_OUBase";
            this.tBox_OUBase.Size = new System.Drawing.Size(427, 20);
            this.tBox_OUBase.TabIndex = 13;
            this.tBox_OUBase.TabStop = false;
            // 
            // btn_CreateOU
            // 
            this.btn_CreateOU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateOU.Location = new System.Drawing.Point(3, 99);
            this.btn_CreateOU.Name = "btn_CreateOU";
            this.btn_CreateOU.Size = new System.Drawing.Size(173, 36);
            this.btn_CreateOU.TabIndex = 12;
            this.btn_CreateOU.TabStop = false;
            this.btn_CreateOU.Text = "Create";
            this.btn_CreateOU.UseVisualStyleBackColor = true;
            this.btn_CreateOU.Click += new System.EventHandler(this.btn_CreateOU_Click);
            // 
            // tbox_OUName
            // 
            this.tbox_OUName.Location = new System.Drawing.Point(6, 34);
            this.tbox_OUName.Name = "tbox_OUName";
            this.tbox_OUName.Size = new System.Drawing.Size(262, 20);
            this.tbox_OUName.TabIndex = 2;
            this.tbox_OUName.TabStop = false;
            // 
            // chBox_PFAD
            // 
            this.chBox_PFAD.AutoSize = true;
            this.chBox_PFAD.Location = new System.Drawing.Point(6, 76);
            this.chBox_PFAD.Name = "chBox_PFAD";
            this.chBox_PFAD.Size = new System.Drawing.Size(214, 17);
            this.chBox_PFAD.TabIndex = 1;
            this.chBox_PFAD.TabStop = false;
            this.chBox_PFAD.Text = "Vor versehentlichem Löschen Schützen";
            this.chBox_PFAD.UseVisualStyleBackColor = true;
            // 
            // lbl_OUName
            // 
            this.lbl_OUName.AutoSize = true;
            this.lbl_OUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OUName.Location = new System.Drawing.Point(6, 11);
            this.lbl_OUName.Name = "lbl_OUName";
            this.lbl_OUName.Size = new System.Drawing.Size(183, 17);
            this.lbl_OUName.TabIndex = 0;
            this.lbl_OUName.Text = "Organisationseinheit Name:";
            // 
            // tPage_PSUser
            // 
            this.tPage_PSUser.BackColor = System.Drawing.Color.Transparent;
            this.tPage_PSUser.Location = new System.Drawing.Point(4, 22);
            this.tPage_PSUser.Name = "tPage_PSUser";
            this.tPage_PSUser.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_PSUser.Size = new System.Drawing.Size(790, 541);
            this.tPage_PSUser.TabIndex = 1;
            this.tPage_PSUser.Text = "PowerShell User";
            // 
            // tPage_PSGroup
            // 
            this.tPage_PSGroup.BackColor = System.Drawing.Color.Transparent;
            this.tPage_PSGroup.Location = new System.Drawing.Point(4, 22);
            this.tPage_PSGroup.Name = "tPage_PSGroup";
            this.tPage_PSGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_PSGroup.Size = new System.Drawing.Size(790, 541);
            this.tPage_PSGroup.TabIndex = 2;
            this.tPage_PSGroup.Text = "PowerShell Group";
            // 
            // tBox_DN
            // 
            this.tBox_DN.Location = new System.Drawing.Point(816, 34);
            this.tBox_DN.Name = "tBox_DN";
            this.tBox_DN.Size = new System.Drawing.Size(186, 20);
            this.tBox_DN.TabIndex = 1;
            this.tBox_DN.TabStop = false;
            // 
            // tBox_TLD
            // 
            this.tBox_TLD.Location = new System.Drawing.Point(816, 84);
            this.tBox_TLD.Name = "tBox_TLD";
            this.tBox_TLD.Size = new System.Drawing.Size(186, 20);
            this.tBox_TLD.TabIndex = 2;
            this.tBox_TLD.TabStop = false;
            // 
            // lbl_DN
            // 
            this.lbl_DN.AutoSize = true;
            this.lbl_DN.Location = new System.Drawing.Point(813, 18);
            this.lbl_DN.Name = "lbl_DN";
            this.lbl_DN.Size = new System.Drawing.Size(195, 13);
            this.lbl_DN.TabIndex = 4;
            this.lbl_DN.Text = "Domain Name (example / sub.example):";
            // 
            // lbl_TLD
            // 
            this.lbl_TLD.AutoSize = true;
            this.lbl_TLD.Location = new System.Drawing.Point(813, 68);
            this.lbl_TLD.Name = "lbl_TLD";
            this.lbl_TLD.Size = new System.Drawing.Size(175, 13);
            this.lbl_TLD.TabIndex = 5;
            this.lbl_TLD.Text = "Top-Level-Domain (com / de / net):";
            // 
            // btn_SaveDNTLD
            // 
            this.btn_SaveDNTLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveDNTLD.Location = new System.Drawing.Point(816, 110);
            this.btn_SaveDNTLD.Name = "btn_SaveDNTLD";
            this.btn_SaveDNTLD.Size = new System.Drawing.Size(186, 36);
            this.btn_SaveDNTLD.TabIndex = 6;
            this.btn_SaveDNTLD.TabStop = false;
            this.btn_SaveDNTLD.Text = "Save";
            this.btn_SaveDNTLD.UseVisualStyleBackColor = true;
            this.btn_SaveDNTLD.Click += new System.EventHandler(this.btn_SaveDNTLD_Click);
            // 
            // btn_ReadDNTLD
            // 
            this.btn_ReadDNTLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadDNTLD.Location = new System.Drawing.Point(815, 280);
            this.btn_ReadDNTLD.Name = "btn_ReadDNTLD";
            this.btn_ReadDNTLD.Size = new System.Drawing.Size(187, 36);
            this.btn_ReadDNTLD.TabIndex = 7;
            this.btn_ReadDNTLD.TabStop = false;
            this.btn_ReadDNTLD.Text = "Read";
            this.btn_ReadDNTLD.UseVisualStyleBackColor = true;
            this.btn_ReadDNTLD.Click += new System.EventHandler(this.btn_ReadDNTLD_Click);
            // 
            // cBox_TLD
            // 
            this.cBox_TLD.FormattingEnabled = true;
            this.cBox_TLD.Location = new System.Drawing.Point(815, 253);
            this.cBox_TLD.Name = "cBox_TLD";
            this.cBox_TLD.Size = new System.Drawing.Size(187, 21);
            this.cBox_TLD.TabIndex = 8;
            this.cBox_TLD.TabStop = false;
            // 
            // cBox_DN
            // 
            this.cBox_DN.FormattingEnabled = true;
            this.cBox_DN.Location = new System.Drawing.Point(815, 203);
            this.cBox_DN.Name = "cBox_DN";
            this.cBox_DN.Size = new System.Drawing.Size(187, 21);
            this.cBox_DN.TabIndex = 9;
            this.cBox_DN.TabStop = false;
            // 
            // lbl_STLD
            // 
            this.lbl_STLD.AutoSize = true;
            this.lbl_STLD.Location = new System.Drawing.Point(812, 237);
            this.lbl_STLD.Name = "lbl_STLD";
            this.lbl_STLD.Size = new System.Drawing.Size(131, 13);
            this.lbl_STLD.TabIndex = 11;
            this.lbl_STLD.Text = "Saved Top-Level-Domain:";
            // 
            // lbl_SDN
            // 
            this.lbl_SDN.AutoSize = true;
            this.lbl_SDN.Location = new System.Drawing.Point(812, 187);
            this.lbl_SDN.Name = "lbl_SDN";
            this.lbl_SDN.Size = new System.Drawing.Size(111, 13);
            this.lbl_SDN.TabIndex = 10;
            this.lbl_SDN.Text = "Saved Domain Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 591);
            this.Controls.Add(this.lbl_STLD);
            this.Controls.Add(this.lbl_SDN);
            this.Controls.Add(this.cBox_DN);
            this.Controls.Add(this.cBox_TLD);
            this.Controls.Add(this.btn_ReadDNTLD);
            this.Controls.Add(this.btn_SaveDNTLD);
            this.Controls.Add(this.lbl_TLD);
            this.Controls.Add(this.lbl_DN);
            this.Controls.Add(this.tBox_TLD);
            this.Controls.Add(this.tBox_DN);
            this.Controls.Add(this.tControl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Powershell Tool";
            this.tControl_Main.ResumeLayout(false);
            this.tPage_PSOU.ResumeLayout(false);
            this.tPage_PSOU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tControl_Main;
        private System.Windows.Forms.TabPage tPage_PSOU;
        private System.Windows.Forms.TabPage tPage_PSUser;
        private System.Windows.Forms.TabPage tPage_PSGroup;
        private System.Windows.Forms.TextBox tBox_DN;
        private System.Windows.Forms.TextBox tBox_TLD;
        private System.Windows.Forms.Label lbl_DN;
        private System.Windows.Forms.Label lbl_TLD;
        private System.Windows.Forms.Button btn_SaveDNTLD;
        private System.Windows.Forms.Button btn_ReadDNTLD;
        private System.Windows.Forms.ComboBox cBox_TLD;
        private System.Windows.Forms.ComboBox cBox_DN;
        private System.Windows.Forms.Label lbl_STLD;
        private System.Windows.Forms.Label lbl_SDN;
        private System.Windows.Forms.Label lbl_OUName;
        private System.Windows.Forms.TextBox tbox_OUName;
        private System.Windows.Forms.CheckBox chBox_PFAD;
        private System.Windows.Forms.Button btn_CreateOU;
        private System.Windows.Forms.Label lbl_OUBase;
        private System.Windows.Forms.TextBox tBox_OUBase;
    }
}

