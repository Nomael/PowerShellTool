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
            tControl_Main = new TabControl();
            tPage_PSOU = new TabPage();
            lbl_OUBase = new Label();
            tBox_PSOUBase = new TextBox();
            btn_CreateOU = new Button();
            tBox_PSOUName = new TextBox();
            chBox_PSOUDel = new CheckBox();
            lbl_OUName = new Label();
            tPage_PSUser = new TabPage();
            tBox_PSUSName = new TextBox();
            lbl_SName = new Label();
            tBox_PSUGName = new TextBox();
            lbl_GName = new Label();
            lbl_UOUPfad = new Label();
            tBox_PSUOU = new TextBox();
            tBox_PSUName = new TextBox();
            lbl_UName = new Label();
            btn_CreateUser = new Button();
            tPage_PSGroup = new TabPage();
            cBox_PSGScope = new ComboBox();
            cBox_PSGCategory = new ComboBox();
            lbl_PSGScope = new Label();
            lbl_PSGCategory = new Label();
            lbl_PSGOU = new Label();
            tBox_PSGOU = new TextBox();
            tBox_PSGName = new TextBox();
            lbl_PSGName = new Label();
            btn_CreateGroup = new Button();
            tBox_DN = new TextBox();
            tBox_TLD = new TextBox();
            lbl_DN = new Label();
            lbl_TLD = new Label();
            btn_SaveDNTLD = new Button();
            btn_ReadDNTLD = new Button();
            cBox_TLD = new ComboBox();
            cBox_DN = new ComboBox();
            lbl_STLD = new Label();
            lbl_SDN = new Label();
            lbl_FilePath = new Label();
            tControl_Main.SuspendLayout();
            tPage_PSOU.SuspendLayout();
            tPage_PSUser.SuspendLayout();
            tPage_PSGroup.SuspendLayout();
            SuspendLayout();
            // 
            // tControl_Main
            // 
            tControl_Main.Controls.Add(tPage_PSOU);
            tControl_Main.Controls.Add(tPage_PSUser);
            tControl_Main.Controls.Add(tPage_PSGroup);
            tControl_Main.Location = new Point(15, 13);
            tControl_Main.Margin = new Padding(4, 3, 4, 3);
            tControl_Main.Name = "tControl_Main";
            tControl_Main.SelectedIndex = 0;
            tControl_Main.Size = new Size(930, 638);
            tControl_Main.TabIndex = 0;
            tControl_Main.TabStop = false;
            // 
            // tPage_PSOU
            // 
            tPage_PSOU.BackColor = Color.Transparent;
            tPage_PSOU.Controls.Add(lbl_OUBase);
            tPage_PSOU.Controls.Add(tBox_PSOUBase);
            tPage_PSOU.Controls.Add(btn_CreateOU);
            tPage_PSOU.Controls.Add(tBox_PSOUName);
            tPage_PSOU.Controls.Add(chBox_PSOUDel);
            tPage_PSOU.Controls.Add(lbl_OUName);
            tPage_PSOU.Location = new Point(4, 24);
            tPage_PSOU.Margin = new Padding(4, 3, 4, 3);
            tPage_PSOU.Name = "tPage_PSOU";
            tPage_PSOU.Padding = new Padding(4, 3, 4, 3);
            tPage_PSOU.Size = new Size(922, 610);
            tPage_PSOU.TabIndex = 0;
            tPage_PSOU.Text = "PowerShell OU";
            // 
            // lbl_OUBase
            // 
            lbl_OUBase.AutoSize = true;
            lbl_OUBase.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_OUBase.Location = new Point(346, 13);
            lbl_OUBase.Margin = new Padding(4, 0, 4, 0);
            lbl_OUBase.Name = "lbl_OUBase";
            lbl_OUBase.Size = new Size(392, 17);
            lbl_OUBase.TabIndex = 14;
            lbl_OUBase.Text = "Path to Organizational Unit (OU / OU.ParentOU.ParentOU...)";
            // 
            // tBox_PSOUBase
            // 
            tBox_PSOUBase.Location = new Point(350, 39);
            tBox_PSOUBase.Margin = new Padding(4, 3, 4, 3);
            tBox_PSOUBase.Name = "tBox_PSOUBase";
            tBox_PSOUBase.Size = new Size(497, 23);
            tBox_PSOUBase.TabIndex = 13;
            tBox_PSOUBase.TabStop = false;
            // 
            // btn_CreateOU
            // 
            btn_CreateOU.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CreateOU.Location = new Point(4, 114);
            btn_CreateOU.Margin = new Padding(4, 3, 4, 3);
            btn_CreateOU.Name = "btn_CreateOU";
            btn_CreateOU.Size = new Size(202, 42);
            btn_CreateOU.TabIndex = 12;
            btn_CreateOU.TabStop = false;
            btn_CreateOU.Text = "Create";
            btn_CreateOU.UseVisualStyleBackColor = true;
            btn_CreateOU.Click += btn_CreateOU_Click;
            // 
            // tBox_PSOUName
            // 
            tBox_PSOUName.Location = new Point(7, 39);
            tBox_PSOUName.Margin = new Padding(4, 3, 4, 3);
            tBox_PSOUName.Name = "tBox_PSOUName";
            tBox_PSOUName.Size = new Size(305, 23);
            tBox_PSOUName.TabIndex = 2;
            tBox_PSOUName.TabStop = false;
            // 
            // chBox_PSOUDel
            // 
            chBox_PSOUDel.AutoSize = true;
            chBox_PSOUDel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chBox_PSOUDel.Location = new Point(7, 83);
            chBox_PSOUDel.Margin = new Padding(4, 3, 4, 3);
            chBox_PSOUDel.Name = "chBox_PSOUDel";
            chBox_PSOUDel.Size = new Size(226, 21);
            chBox_PSOUDel.TabIndex = 1;
            chBox_PSOUDel.TabStop = false;
            chBox_PSOUDel.Text = "Protect from accidental deletion";
            chBox_PSOUDel.UseVisualStyleBackColor = true;
            // 
            // lbl_OUName
            // 
            lbl_OUName.AutoSize = true;
            lbl_OUName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_OUName.Location = new Point(7, 13);
            lbl_OUName.Margin = new Padding(4, 0, 4, 0);
            lbl_OUName.Name = "lbl_OUName";
            lbl_OUName.Size = new Size(174, 17);
            lbl_OUName.TabIndex = 0;
            lbl_OUName.Text = "Organizational Unit Name:";
            // 
            // tPage_PSUser
            // 
            tPage_PSUser.BackColor = Color.Transparent;
            tPage_PSUser.Controls.Add(tBox_PSUSName);
            tPage_PSUser.Controls.Add(lbl_SName);
            tPage_PSUser.Controls.Add(tBox_PSUGName);
            tPage_PSUser.Controls.Add(lbl_GName);
            tPage_PSUser.Controls.Add(lbl_UOUPfad);
            tPage_PSUser.Controls.Add(tBox_PSUOU);
            tPage_PSUser.Controls.Add(tBox_PSUName);
            tPage_PSUser.Controls.Add(lbl_UName);
            tPage_PSUser.Controls.Add(btn_CreateUser);
            tPage_PSUser.Location = new Point(4, 24);
            tPage_PSUser.Margin = new Padding(4, 3, 4, 3);
            tPage_PSUser.Name = "tPage_PSUser";
            tPage_PSUser.Padding = new Padding(4, 3, 4, 3);
            tPage_PSUser.Size = new Size(922, 610);
            tPage_PSUser.TabIndex = 1;
            tPage_PSUser.Text = "PowerShell User";
            // 
            // tBox_PSUSName
            // 
            tBox_PSUSName.Location = new Point(7, 137);
            tBox_PSUSName.Margin = new Padding(4, 3, 4, 3);
            tBox_PSUSName.Name = "tBox_PSUSName";
            tBox_PSUSName.Size = new Size(305, 23);
            tBox_PSUSName.TabIndex = 22;
            tBox_PSUSName.TabStop = false;
            // 
            // lbl_SName
            // 
            lbl_SName.AutoSize = true;
            lbl_SName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SName.Location = new Point(7, 111);
            lbl_SName.Margin = new Padding(4, 0, 4, 0);
            lbl_SName.Name = "lbl_SName";
            lbl_SName.Size = new Size(151, 17);
            lbl_SName.TabIndex = 21;
            lbl_SName.Text = "Surname (Nachname):";
            // 
            // tBox_PSUGName
            // 
            tBox_PSUGName.Location = new Point(7, 84);
            tBox_PSUGName.Margin = new Padding(4, 3, 4, 3);
            tBox_PSUGName.Name = "tBox_PSUGName";
            tBox_PSUGName.Size = new Size(305, 23);
            tBox_PSUGName.TabIndex = 20;
            tBox_PSUGName.TabStop = false;
            // 
            // lbl_GName
            // 
            lbl_GName.AutoSize = true;
            lbl_GName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GName.Location = new Point(7, 58);
            lbl_GName.Margin = new Padding(4, 0, 4, 0);
            lbl_GName.Name = "lbl_GName";
            lbl_GName.Size = new Size(161, 17);
            lbl_GName.TabIndex = 19;
            lbl_GName.Text = "Given Name (Vorname):";
            // 
            // lbl_UOUPfad
            // 
            lbl_UOUPfad.AutoSize = true;
            lbl_UOUPfad.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_UOUPfad.Location = new Point(346, 3);
            lbl_UOUPfad.Margin = new Padding(4, 0, 4, 0);
            lbl_UOUPfad.Name = "lbl_UOUPfad";
            lbl_UOUPfad.Size = new Size(392, 17);
            lbl_UOUPfad.TabIndex = 18;
            lbl_UOUPfad.Text = "Path to Organizational Unit (OU / OU.ParentOU.ParentOU...)";
            // 
            // tBox_PSUOU
            // 
            tBox_PSUOU.Location = new Point(350, 30);
            tBox_PSUOU.Margin = new Padding(4, 3, 4, 3);
            tBox_PSUOU.Name = "tBox_PSUOU";
            tBox_PSUOU.Size = new Size(497, 23);
            tBox_PSUOU.TabIndex = 17;
            tBox_PSUOU.TabStop = false;
            // 
            // tBox_PSUName
            // 
            tBox_PSUName.Location = new Point(7, 30);
            tBox_PSUName.Margin = new Padding(4, 3, 4, 3);
            tBox_PSUName.Name = "tBox_PSUName";
            tBox_PSUName.Size = new Size(305, 23);
            tBox_PSUName.TabIndex = 16;
            tBox_PSUName.TabStop = false;
            // 
            // lbl_UName
            // 
            lbl_UName.AutoSize = true;
            lbl_UName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_UName.Location = new Point(7, 3);
            lbl_UName.Margin = new Padding(4, 0, 4, 0);
            lbl_UName.Name = "lbl_UName";
            lbl_UName.Size = new Size(165, 17);
            lbl_UName.TabIndex = 15;
            lbl_UName.Text = "Username / Login Name:";
            // 
            // btn_CreateUser
            // 
            btn_CreateUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CreateUser.Location = new Point(7, 167);
            btn_CreateUser.Margin = new Padding(4, 3, 4, 3);
            btn_CreateUser.Name = "btn_CreateUser";
            btn_CreateUser.Size = new Size(202, 42);
            btn_CreateUser.TabIndex = 13;
            btn_CreateUser.TabStop = false;
            btn_CreateUser.Text = "Create";
            btn_CreateUser.UseVisualStyleBackColor = true;
            btn_CreateUser.Click += btn_CreateUser_Click;
            // 
            // tPage_PSGroup
            // 
            tPage_PSGroup.BackColor = Color.Transparent;
            tPage_PSGroup.Controls.Add(cBox_PSGScope);
            tPage_PSGroup.Controls.Add(cBox_PSGCategory);
            tPage_PSGroup.Controls.Add(lbl_PSGScope);
            tPage_PSGroup.Controls.Add(lbl_PSGCategory);
            tPage_PSGroup.Controls.Add(lbl_PSGOU);
            tPage_PSGroup.Controls.Add(tBox_PSGOU);
            tPage_PSGroup.Controls.Add(tBox_PSGName);
            tPage_PSGroup.Controls.Add(lbl_PSGName);
            tPage_PSGroup.Controls.Add(btn_CreateGroup);
            tPage_PSGroup.Location = new Point(4, 24);
            tPage_PSGroup.Margin = new Padding(4, 3, 4, 3);
            tPage_PSGroup.Name = "tPage_PSGroup";
            tPage_PSGroup.Padding = new Padding(4, 3, 4, 3);
            tPage_PSGroup.Size = new Size(922, 610);
            tPage_PSGroup.TabIndex = 2;
            tPage_PSGroup.Text = "PowerShell Group";
            // 
            // cBox_PSGScope
            // 
            cBox_PSGScope.FormattingEnabled = true;
            cBox_PSGScope.Location = new Point(7, 134);
            cBox_PSGScope.Margin = new Padding(4, 3, 4, 3);
            cBox_PSGScope.Name = "cBox_PSGScope";
            cBox_PSGScope.Size = new Size(305, 23);
            cBox_PSGScope.TabIndex = 31;
            cBox_PSGScope.TabStop = false;
            // 
            // cBox_PSGCategory
            // 
            cBox_PSGCategory.FormattingEnabled = true;
            cBox_PSGCategory.Location = new Point(7, 81);
            cBox_PSGCategory.Margin = new Padding(4, 3, 4, 3);
            cBox_PSGCategory.Name = "cBox_PSGCategory";
            cBox_PSGCategory.Size = new Size(305, 23);
            cBox_PSGCategory.TabIndex = 12;
            cBox_PSGCategory.TabStop = false;
            // 
            // lbl_PSGScope
            // 
            lbl_PSGScope.AutoSize = true;
            lbl_PSGScope.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PSGScope.Location = new Point(7, 111);
            lbl_PSGScope.Margin = new Padding(4, 0, 4, 0);
            lbl_PSGScope.Name = "lbl_PSGScope";
            lbl_PSGScope.Size = new Size(96, 17);
            lbl_PSGScope.TabIndex = 30;
            lbl_PSGScope.Text = "Group Scope:";
            // 
            // lbl_PSGCategory
            // 
            lbl_PSGCategory.AutoSize = true;
            lbl_PSGCategory.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PSGCategory.Location = new Point(7, 58);
            lbl_PSGCategory.Margin = new Padding(4, 0, 4, 0);
            lbl_PSGCategory.Name = "lbl_PSGCategory";
            lbl_PSGCategory.Size = new Size(113, 17);
            lbl_PSGCategory.TabIndex = 28;
            lbl_PSGCategory.Text = "Group Category:";
            // 
            // lbl_PSGOU
            // 
            lbl_PSGOU.AutoSize = true;
            lbl_PSGOU.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PSGOU.Location = new Point(346, 3);
            lbl_PSGOU.Margin = new Padding(4, 0, 4, 0);
            lbl_PSGOU.Name = "lbl_PSGOU";
            lbl_PSGOU.Size = new Size(392, 17);
            lbl_PSGOU.TabIndex = 27;
            lbl_PSGOU.Text = "Path to Organizational Unit (OU / OU.ParentOU.ParentOU...)";
            // 
            // tBox_PSGOU
            // 
            tBox_PSGOU.Location = new Point(350, 30);
            tBox_PSGOU.Margin = new Padding(4, 3, 4, 3);
            tBox_PSGOU.Name = "tBox_PSGOU";
            tBox_PSGOU.Size = new Size(497, 23);
            tBox_PSGOU.TabIndex = 26;
            tBox_PSGOU.TabStop = false;
            // 
            // tBox_PSGName
            // 
            tBox_PSGName.Location = new Point(7, 27);
            tBox_PSGName.Margin = new Padding(4, 3, 4, 3);
            tBox_PSGName.Name = "tBox_PSGName";
            tBox_PSGName.Size = new Size(305, 23);
            tBox_PSGName.TabIndex = 25;
            tBox_PSGName.TabStop = false;
            // 
            // lbl_PSGName
            // 
            lbl_PSGName.AutoSize = true;
            lbl_PSGName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PSGName.Location = new Point(7, 3);
            lbl_PSGName.Margin = new Padding(4, 0, 4, 0);
            lbl_PSGName.Name = "lbl_PSGName";
            lbl_PSGName.Size = new Size(93, 17);
            lbl_PSGName.TabIndex = 24;
            lbl_PSGName.Text = "Group Name:";
            // 
            // btn_CreateGroup
            // 
            btn_CreateGroup.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CreateGroup.Location = new Point(7, 167);
            btn_CreateGroup.Margin = new Padding(4, 3, 4, 3);
            btn_CreateGroup.Name = "btn_CreateGroup";
            btn_CreateGroup.Size = new Size(202, 42);
            btn_CreateGroup.TabIndex = 23;
            btn_CreateGroup.TabStop = false;
            btn_CreateGroup.Text = "Create";
            btn_CreateGroup.UseVisualStyleBackColor = true;
            btn_CreateGroup.Click += btn_CreateGroup_Click;
            // 
            // tBox_DN
            // 
            tBox_DN.Location = new Point(952, 39);
            tBox_DN.Margin = new Padding(4, 3, 4, 3);
            tBox_DN.Name = "tBox_DN";
            tBox_DN.Size = new Size(216, 23);
            tBox_DN.TabIndex = 1;
            tBox_DN.TabStop = false;
            // 
            // tBox_TLD
            // 
            tBox_TLD.Location = new Point(952, 97);
            tBox_TLD.Margin = new Padding(4, 3, 4, 3);
            tBox_TLD.Name = "tBox_TLD";
            tBox_TLD.Size = new Size(216, 23);
            tBox_TLD.TabIndex = 2;
            tBox_TLD.TabStop = false;
            // 
            // lbl_DN
            // 
            lbl_DN.AutoSize = true;
            lbl_DN.Location = new Point(948, 21);
            lbl_DN.Margin = new Padding(4, 0, 4, 0);
            lbl_DN.Name = "lbl_DN";
            lbl_DN.Size = new Size(219, 15);
            lbl_DN.TabIndex = 4;
            lbl_DN.Text = "Domain Name (example / sub.example):";
            // 
            // lbl_TLD
            // 
            lbl_TLD.AutoSize = true;
            lbl_TLD.Location = new Point(948, 78);
            lbl_TLD.Margin = new Padding(4, 0, 4, 0);
            lbl_TLD.Name = "lbl_TLD";
            lbl_TLD.Size = new Size(196, 15);
            lbl_TLD.TabIndex = 5;
            lbl_TLD.Text = "Top-Level-Domain (com / de / net):";
            // 
            // btn_SaveDNTLD
            // 
            btn_SaveDNTLD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_SaveDNTLD.Location = new Point(952, 127);
            btn_SaveDNTLD.Margin = new Padding(4, 3, 4, 3);
            btn_SaveDNTLD.Name = "btn_SaveDNTLD";
            btn_SaveDNTLD.Size = new Size(217, 42);
            btn_SaveDNTLD.TabIndex = 6;
            btn_SaveDNTLD.TabStop = false;
            btn_SaveDNTLD.Text = "Save";
            btn_SaveDNTLD.UseVisualStyleBackColor = true;
            btn_SaveDNTLD.Click += btn_SaveDNTLD_Click;
            // 
            // btn_ReadDNTLD
            // 
            btn_ReadDNTLD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ReadDNTLD.Location = new Point(951, 323);
            btn_ReadDNTLD.Margin = new Padding(4, 3, 4, 3);
            btn_ReadDNTLD.Name = "btn_ReadDNTLD";
            btn_ReadDNTLD.Size = new Size(218, 42);
            btn_ReadDNTLD.TabIndex = 7;
            btn_ReadDNTLD.TabStop = false;
            btn_ReadDNTLD.Text = "Read";
            btn_ReadDNTLD.UseVisualStyleBackColor = true;
            btn_ReadDNTLD.Click += btn_ReadDNTLD_Click;
            // 
            // cBox_TLD
            // 
            cBox_TLD.FormattingEnabled = true;
            cBox_TLD.Location = new Point(951, 292);
            cBox_TLD.Margin = new Padding(4, 3, 4, 3);
            cBox_TLD.Name = "cBox_TLD";
            cBox_TLD.Size = new Size(218, 23);
            cBox_TLD.TabIndex = 8;
            cBox_TLD.TabStop = false;
            // 
            // cBox_DN
            // 
            cBox_DN.FormattingEnabled = true;
            cBox_DN.Location = new Point(951, 234);
            cBox_DN.Margin = new Padding(4, 3, 4, 3);
            cBox_DN.Name = "cBox_DN";
            cBox_DN.Size = new Size(218, 23);
            cBox_DN.TabIndex = 9;
            cBox_DN.TabStop = false;
            // 
            // lbl_STLD
            // 
            lbl_STLD.AutoSize = true;
            lbl_STLD.Location = new Point(947, 273);
            lbl_STLD.Margin = new Padding(4, 0, 4, 0);
            lbl_STLD.Name = "lbl_STLD";
            lbl_STLD.Size = new Size(143, 15);
            lbl_STLD.TabIndex = 11;
            lbl_STLD.Text = "Saved Top-Level-Domain:";
            // 
            // lbl_SDN
            // 
            lbl_SDN.AutoSize = true;
            lbl_SDN.Location = new Point(947, 216);
            lbl_SDN.Margin = new Padding(4, 0, 4, 0);
            lbl_SDN.Name = "lbl_SDN";
            lbl_SDN.Size = new Size(121, 15);
            lbl_SDN.TabIndex = 10;
            lbl_SDN.Text = "Saved Domain Name:";
            // 
            // lbl_FilePath
            // 
            lbl_FilePath.AutoSize = true;
            lbl_FilePath.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FilePath.Location = new Point(12, 654);
            lbl_FilePath.Margin = new Padding(4, 0, 4, 0);
            lbl_FilePath.Name = "lbl_FilePath";
            lbl_FilePath.Size = new Size(115, 17);
            lbl_FilePath.TabIndex = 12;
            lbl_FilePath.Text = "Path to Savefile: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1183, 682);
            Controls.Add(lbl_FilePath);
            Controls.Add(lbl_STLD);
            Controls.Add(lbl_SDN);
            Controls.Add(cBox_DN);
            Controls.Add(cBox_TLD);
            Controls.Add(btn_ReadDNTLD);
            Controls.Add(btn_SaveDNTLD);
            Controls.Add(lbl_TLD);
            Controls.Add(lbl_DN);
            Controls.Add(tBox_TLD);
            Controls.Add(tBox_DN);
            Controls.Add(tControl_Main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Powershell Tool";
            tControl_Main.ResumeLayout(false);
            tPage_PSOU.ResumeLayout(false);
            tPage_PSOU.PerformLayout();
            tPage_PSUser.ResumeLayout(false);
            tPage_PSUser.PerformLayout();
            tPage_PSGroup.ResumeLayout(false);
            tPage_PSGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.TextBox tBox_PSOUName;
        private System.Windows.Forms.CheckBox chBox_PSOUDel;
        private System.Windows.Forms.Button btn_CreateOU;
        private System.Windows.Forms.Label lbl_OUBase;
        private System.Windows.Forms.TextBox tBox_PSOUBase;
        private System.Windows.Forms.Button btn_CreateUser;
        private System.Windows.Forms.Label lbl_UOUPfad;
        private System.Windows.Forms.TextBox tBox_PSUOU;
        private System.Windows.Forms.TextBox tBox_PSUName;
        private System.Windows.Forms.Label lbl_UName;
        private System.Windows.Forms.TextBox tBox_PSUSName;
        private System.Windows.Forms.Label lbl_SName;
        private System.Windows.Forms.TextBox tBox_PSUGName;
        private System.Windows.Forms.Label lbl_GName;
        private System.Windows.Forms.Label lbl_PSGScope;
        private System.Windows.Forms.Label lbl_PSGCategory;
        private System.Windows.Forms.Label lbl_PSGOU;
        private System.Windows.Forms.TextBox tBox_PSGOU;
        private System.Windows.Forms.TextBox tBox_PSGName;
        private System.Windows.Forms.Label lbl_PSGName;
        private System.Windows.Forms.Button btn_CreateGroup;
        private System.Windows.Forms.ComboBox cBox_PSGScope;
        private System.Windows.Forms.ComboBox cBox_PSGCategory;
        private System.Windows.Forms.Label lbl_FilePath;
    }
}

