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
            this.tBox_PSOUBase = new System.Windows.Forms.TextBox();
            this.btn_CreateOU = new System.Windows.Forms.Button();
            this.tBox_PSOUName = new System.Windows.Forms.TextBox();
            this.chBox_PSOUDel = new System.Windows.Forms.CheckBox();
            this.lbl_OUName = new System.Windows.Forms.Label();
            this.tPage_PSUser = new System.Windows.Forms.TabPage();
            this.tBox_PSUSName = new System.Windows.Forms.TextBox();
            this.lbl_SName = new System.Windows.Forms.Label();
            this.tBox_PSUGName = new System.Windows.Forms.TextBox();
            this.lbl_GName = new System.Windows.Forms.Label();
            this.lbl_UOUPfad = new System.Windows.Forms.Label();
            this.tBox_PSUOU = new System.Windows.Forms.TextBox();
            this.tBox_PSUName = new System.Windows.Forms.TextBox();
            this.lbl_UName = new System.Windows.Forms.Label();
            this.btn_CreateUser = new System.Windows.Forms.Button();
            this.tPage_PSGroup = new System.Windows.Forms.TabPage();
            this.cBox_PSGScope = new System.Windows.Forms.ComboBox();
            this.cBox_PSGCategory = new System.Windows.Forms.ComboBox();
            this.lbl_PSGScope = new System.Windows.Forms.Label();
            this.lbl_PSGCategory = new System.Windows.Forms.Label();
            this.lbl_PSGOU = new System.Windows.Forms.Label();
            this.tBox_PSGOU = new System.Windows.Forms.TextBox();
            this.tBox_PSGName = new System.Windows.Forms.TextBox();
            this.lbl_PSGName = new System.Windows.Forms.Label();
            this.btn_CreateGroup = new System.Windows.Forms.Button();
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
            this.lbl_FilePath = new System.Windows.Forms.Label();
            this.tControl_Main.SuspendLayout();
            this.tPage_PSOU.SuspendLayout();
            this.tPage_PSUser.SuspendLayout();
            this.tPage_PSGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tControl_Main
            // 
            this.tControl_Main.Controls.Add(this.tPage_PSOU);
            this.tControl_Main.Controls.Add(this.tPage_PSUser);
            this.tControl_Main.Controls.Add(this.tPage_PSGroup);
            this.tControl_Main.Location = new System.Drawing.Point(17, 13);
            this.tControl_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tControl_Main.Name = "tControl_Main";
            this.tControl_Main.SelectedIndex = 0;
            this.tControl_Main.Size = new System.Drawing.Size(1063, 681);
            this.tControl_Main.TabIndex = 0;
            this.tControl_Main.TabStop = false;
            // 
            // tPage_PSOU
            // 
            this.tPage_PSOU.BackColor = System.Drawing.Color.Transparent;
            this.tPage_PSOU.Controls.Add(this.lbl_OUBase);
            this.tPage_PSOU.Controls.Add(this.tBox_PSOUBase);
            this.tPage_PSOU.Controls.Add(this.btn_CreateOU);
            this.tPage_PSOU.Controls.Add(this.tBox_PSOUName);
            this.tPage_PSOU.Controls.Add(this.chBox_PSOUDel);
            this.tPage_PSOU.Controls.Add(this.lbl_OUName);
            this.tPage_PSOU.Location = new System.Drawing.Point(4, 25);
            this.tPage_PSOU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPage_PSOU.Name = "tPage_PSOU";
            this.tPage_PSOU.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPage_PSOU.Size = new System.Drawing.Size(1055, 652);
            this.tPage_PSOU.TabIndex = 0;
            this.tPage_PSOU.Text = "PowerShell OU";
            // 
            // lbl_OUBase
            // 
            this.lbl_OUBase.AutoSize = true;
            this.lbl_OUBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OUBase.Location = new System.Drawing.Point(396, 14);
            this.lbl_OUBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OUBase.Name = "lbl_OUBase";
            this.lbl_OUBase.Size = new System.Drawing.Size(460, 20);
            this.lbl_OUBase.TabIndex = 14;
            this.lbl_OUBase.Text = "Path to Organizational Unit (OU / OU.ParentOU.ParentOU...)";
            // 
            // tBox_PSOUBase
            // 
            this.tBox_PSOUBase.Location = new System.Drawing.Point(400, 42);
            this.tBox_PSOUBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBox_PSOUBase.Name = "tBox_PSOUBase";
            this.tBox_PSOUBase.Size = new System.Drawing.Size(568, 22);
            this.tBox_PSOUBase.TabIndex = 13;
            this.tBox_PSOUBase.TabStop = false;
            // 
            // btn_CreateOU
            // 
            this.btn_CreateOU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateOU.Location = new System.Drawing.Point(4, 122);
            this.btn_CreateOU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CreateOU.Name = "btn_CreateOU";
            this.btn_CreateOU.Size = new System.Drawing.Size(231, 44);
            this.btn_CreateOU.TabIndex = 12;
            this.btn_CreateOU.TabStop = false;
            this.btn_CreateOU.Text = "Create";
            this.btn_CreateOU.UseVisualStyleBackColor = true;
            this.btn_CreateOU.Click += new System.EventHandler(this.btn_CreateOU_Click);
            // 
            // tBox_PSOUName
            // 
            this.tBox_PSOUName.Location = new System.Drawing.Point(8, 42);
            this.tBox_PSOUName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBox_PSOUName.Name = "tBox_PSOUName";
            this.tBox_PSOUName.Size = new System.Drawing.Size(348, 22);
            this.tBox_PSOUName.TabIndex = 2;
            this.tBox_PSOUName.TabStop = false;
            // 
            // chBox_PSOUDel
            // 
            this.chBox_PSOUDel.AutoSize = true;
            this.chBox_PSOUDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBox_PSOUDel.Location = new System.Drawing.Point(8, 89);
            this.chBox_PSOUDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBox_PSOUDel.Name = "chBox_PSOUDel";
            this.chBox_PSOUDel.Size = new System.Drawing.Size(268, 24);
            this.chBox_PSOUDel.TabIndex = 1;
            this.chBox_PSOUDel.TabStop = false;
            this.chBox_PSOUDel.Text = "Protect from accidental deletion";
            this.chBox_PSOUDel.UseVisualStyleBackColor = true;
            // 
            // lbl_OUName
            // 
            this.lbl_OUName.AutoSize = true;
            this.lbl_OUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OUName.Location = new System.Drawing.Point(8, 14);
            this.lbl_OUName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OUName.Name = "lbl_OUName";
            this.lbl_OUName.Size = new System.Drawing.Size(206, 20);
            this.lbl_OUName.TabIndex = 0;
            this.lbl_OUName.Text = "Organizational Unit Name:";
            // 
            // tPage_PSUser
            // 
            this.tPage_PSUser.BackColor = System.Drawing.Color.Transparent;
            this.tPage_PSUser.Controls.Add(this.tBox_PSUSName);
            this.tPage_PSUser.Controls.Add(this.lbl_SName);
            this.tPage_PSUser.Controls.Add(this.tBox_PSUGName);
            this.tPage_PSUser.Controls.Add(this.lbl_GName);
            this.tPage_PSUser.Controls.Add(this.lbl_UOUPfad);
            this.tPage_PSUser.Controls.Add(this.tBox_PSUOU);
            this.tPage_PSUser.Controls.Add(this.tBox_PSUName);
            this.tPage_PSUser.Controls.Add(this.lbl_UName);
            this.tPage_PSUser.Controls.Add(this.btn_CreateUser);
            this.tPage_PSUser.Location = new System.Drawing.Point(4, 25);
            this.tPage_PSUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPage_PSUser.Name = "tPage_PSUser";
            this.tPage_PSUser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPage_PSUser.Size = new System.Drawing.Size(1056, 669);
            this.tPage_PSUser.TabIndex = 1;
            this.tPage_PSUser.Text = "PowerShell User";
            // 
            // tBox_PSUSName
            // 
            this.tBox_PSUSName.Location = new System.Drawing.Point(8, 146);
            this.tBox_PSUSName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBox_PSUSName.Name = "tBox_PSUSName";
            this.tBox_PSUSName.Size = new System.Drawing.Size(348, 22);
            this.tBox_PSUSName.TabIndex = 22;
            this.tBox_PSUSName.TabStop = false;
            // 
            // lbl_SName
            // 
            this.lbl_SName.AutoSize = true;
            this.lbl_SName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SName.Location = new System.Drawing.Point(8, 118);
            this.lbl_SName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SName.Name = "lbl_SName";
            this.lbl_SName.Size = new System.Drawing.Size(178, 20);
            this.lbl_SName.TabIndex = 21;
            this.lbl_SName.Text = "Surname (Nachname):";
            // 
            // tBox_PSUGName
            // 
            this.tBox_PSUGName.Location = new System.Drawing.Point(8, 90);
            this.tBox_PSUGName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBox_PSUGName.Name = "tBox_PSUGName";
            this.tBox_PSUGName.Size = new System.Drawing.Size(348, 22);
            this.tBox_PSUGName.TabIndex = 20;
            this.tBox_PSUGName.TabStop = false;
            // 
            // lbl_GName
            // 
            this.lbl_GName.AutoSize = true;
            this.lbl_GName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GName.Location = new System.Drawing.Point(8, 62);
            this.lbl_GName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GName.Name = "lbl_GName";
            this.lbl_GName.Size = new System.Drawing.Size(190, 20);
            this.lbl_GName.TabIndex = 19;
            this.lbl_GName.Text = "Given Name (Vorname):";
            // 
            // lbl_UOUPfad
            // 
            this.lbl_UOUPfad.AutoSize = true;
            this.lbl_UOUPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UOUPfad.Location = new System.Drawing.Point(396, 4);
            this.lbl_UOUPfad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UOUPfad.Name = "lbl_UOUPfad";
            this.lbl_UOUPfad.Size = new System.Drawing.Size(460, 20);
            this.lbl_UOUPfad.TabIndex = 18;
            this.lbl_UOUPfad.Text = "Path to Organizational Unit (OU / OU.ParentOU.ParentOU...)";
            // 
            // tBox_PSUOU
            // 
            this.tBox_PSUOU.Location = new System.Drawing.Point(400, 32);
            this.tBox_PSUOU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBox_PSUOU.Name = "tBox_PSUOU";
            this.tBox_PSUOU.Size = new System.Drawing.Size(568, 22);
            this.tBox_PSUOU.TabIndex = 17;
            this.tBox_PSUOU.TabStop = false;
            // 
            // tBox_PSUName
            // 
            this.tBox_PSUName.Location = new System.Drawing.Point(8, 32);
            this.tBox_PSUName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBox_PSUName.Name = "tBox_PSUName";
            this.tBox_PSUName.Size = new System.Drawing.Size(348, 22);
            this.tBox_PSUName.TabIndex = 16;
            this.tBox_PSUName.TabStop = false;
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.Location = new System.Drawing.Point(8, 4);
            this.lbl_UName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(196, 20);
            this.lbl_UName.TabIndex = 15;
            this.lbl_UName.Text = "Username / Login Name:";
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateUser.Location = new System.Drawing.Point(8, 178);
            this.btn_CreateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(231, 44);
            this.btn_CreateUser.TabIndex = 13;
            this.btn_CreateUser.TabStop = false;
            this.btn_CreateUser.Text = "Create";
            this.btn_CreateUser.UseVisualStyleBackColor = true;
            this.btn_CreateUser.Click += new System.EventHandler(this.btn_CreateUser_Click);
            // 
            // tPage_PSGroup
            // 
            this.tPage_PSGroup.BackColor = System.Drawing.Color.Transparent;
            this.tPage_PSGroup.Controls.Add(this.cBox_PSGScope);
            this.tPage_PSGroup.Controls.Add(this.cBox_PSGCategory);
            this.tPage_PSGroup.Controls.Add(this.lbl_PSGScope);
            this.tPage_PSGroup.Controls.Add(this.lbl_PSGCategory);
            this.tPage_PSGroup.Controls.Add(this.lbl_PSGOU);
            this.tPage_PSGroup.Controls.Add(this.tBox_PSGOU);
            this.tPage_PSGroup.Controls.Add(this.tBox_PSGName);
            this.tPage_PSGroup.Controls.Add(this.lbl_PSGName);
            this.tPage_PSGroup.Controls.Add(this.btn_CreateGroup);
            this.tPage_PSGroup.Location = new System.Drawing.Point(4, 25);
            this.tPage_PSGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPage_PSGroup.Name = "tPage_PSGroup";
            this.tPage_PSGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tPage_PSGroup.Size = new System.Drawing.Size(1056, 669);
            this.tPage_PSGroup.TabIndex = 2;
            this.tPage_PSGroup.Text = "PowerShell Group";
            // 
            // cBox_PSGScope
            // 
            this.cBox_PSGScope.FormattingEnabled = true;
            this.cBox_PSGScope.Location = new System.Drawing.Point(8, 143);
            this.cBox_PSGScope.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox_PSGScope.Name = "cBox_PSGScope";
            this.cBox_PSGScope.Size = new System.Drawing.Size(348, 24);
            this.cBox_PSGScope.TabIndex = 31;
            this.cBox_PSGScope.TabStop = false;
            // 
            // cBox_PSGCategory
            // 
            this.cBox_PSGCategory.FormattingEnabled = true;
            this.cBox_PSGCategory.Location = new System.Drawing.Point(8, 86);
            this.cBox_PSGCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox_PSGCategory.Name = "cBox_PSGCategory";
            this.cBox_PSGCategory.Size = new System.Drawing.Size(348, 24);
            this.cBox_PSGCategory.TabIndex = 12;
            this.cBox_PSGCategory.TabStop = false;
            // 
            // lbl_PSGScope
            // 
            this.lbl_PSGScope.AutoSize = true;
            this.lbl_PSGScope.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PSGScope.Location = new System.Drawing.Point(8, 118);
            this.lbl_PSGScope.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PSGScope.Name = "lbl_PSGScope";
            this.lbl_PSGScope.Size = new System.Drawing.Size(112, 20);
            this.lbl_PSGScope.TabIndex = 30;
            this.lbl_PSGScope.Text = "Group Scope:";
            // 
            // lbl_PSGCategory
            // 
            this.lbl_PSGCategory.AutoSize = true;
            this.lbl_PSGCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PSGCategory.Location = new System.Drawing.Point(8, 62);
            this.lbl_PSGCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PSGCategory.Name = "lbl_PSGCategory";
            this.lbl_PSGCategory.Size = new System.Drawing.Size(132, 20);
            this.lbl_PSGCategory.TabIndex = 28;
            this.lbl_PSGCategory.Text = "Group Category:";
            // 
            // lbl_PSGOU
            // 
            this.lbl_PSGOU.AutoSize = true;
            this.lbl_PSGOU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PSGOU.Location = new System.Drawing.Point(396, 4);
            this.lbl_PSGOU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PSGOU.Name = "lbl_PSGOU";
            this.lbl_PSGOU.Size = new System.Drawing.Size(460, 20);
            this.lbl_PSGOU.TabIndex = 27;
            this.lbl_PSGOU.Text = "Path to Organizational Unit (OU / OU.ParentOU.ParentOU...)";
            // 
            // tBox_PSGOU
            // 
            this.tBox_PSGOU.Location = new System.Drawing.Point(400, 32);
            this.tBox_PSGOU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBox_PSGOU.Name = "tBox_PSGOU";
            this.tBox_PSGOU.Size = new System.Drawing.Size(568, 22);
            this.tBox_PSGOU.TabIndex = 26;
            this.tBox_PSGOU.TabStop = false;
            // 
            // tBox_PSGName
            // 
            this.tBox_PSGName.Location = new System.Drawing.Point(8, 28);
            this.tBox_PSGName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBox_PSGName.Name = "tBox_PSGName";
            this.tBox_PSGName.Size = new System.Drawing.Size(348, 22);
            this.tBox_PSGName.TabIndex = 25;
            this.tBox_PSGName.TabStop = false;
            // 
            // lbl_PSGName
            // 
            this.lbl_PSGName.AutoSize = true;
            this.lbl_PSGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PSGName.Location = new System.Drawing.Point(8, 4);
            this.lbl_PSGName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PSGName.Name = "lbl_PSGName";
            this.lbl_PSGName.Size = new System.Drawing.Size(109, 20);
            this.lbl_PSGName.TabIndex = 24;
            this.lbl_PSGName.Text = "Group Name:";
            // 
            // btn_CreateGroup
            // 
            this.btn_CreateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateGroup.Location = new System.Drawing.Point(8, 178);
            this.btn_CreateGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CreateGroup.Name = "btn_CreateGroup";
            this.btn_CreateGroup.Size = new System.Drawing.Size(231, 44);
            this.btn_CreateGroup.TabIndex = 23;
            this.btn_CreateGroup.TabStop = false;
            this.btn_CreateGroup.Text = "Create";
            this.btn_CreateGroup.UseVisualStyleBackColor = true;
            this.btn_CreateGroup.Click += new System.EventHandler(this.btn_CreateGroup_Click);
            // 
            // tBox_DN
            // 
            this.tBox_DN.Location = new System.Drawing.Point(1088, 42);
            this.tBox_DN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBox_DN.Name = "tBox_DN";
            this.tBox_DN.Size = new System.Drawing.Size(247, 22);
            this.tBox_DN.TabIndex = 1;
            this.tBox_DN.TabStop = false;
            // 
            // tBox_TLD
            // 
            this.tBox_TLD.Location = new System.Drawing.Point(1088, 103);
            this.tBox_TLD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBox_TLD.Name = "tBox_TLD";
            this.tBox_TLD.Size = new System.Drawing.Size(247, 22);
            this.tBox_TLD.TabIndex = 2;
            this.tBox_TLD.TabStop = false;
            // 
            // lbl_DN
            // 
            this.lbl_DN.AutoSize = true;
            this.lbl_DN.Location = new System.Drawing.Point(1084, 22);
            this.lbl_DN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DN.Name = "lbl_DN";
            this.lbl_DN.Size = new System.Drawing.Size(247, 16);
            this.lbl_DN.TabIndex = 4;
            this.lbl_DN.Text = "Domain Name (example / sub.example):";
            // 
            // lbl_TLD
            // 
            this.lbl_TLD.AutoSize = true;
            this.lbl_TLD.Location = new System.Drawing.Point(1084, 84);
            this.lbl_TLD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TLD.Name = "lbl_TLD";
            this.lbl_TLD.Size = new System.Drawing.Size(214, 16);
            this.lbl_TLD.TabIndex = 5;
            this.lbl_TLD.Text = "Top-Level-Domain (com / de / net):";
            // 
            // btn_SaveDNTLD
            // 
            this.btn_SaveDNTLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveDNTLD.Location = new System.Drawing.Point(1088, 135);
            this.btn_SaveDNTLD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SaveDNTLD.Name = "btn_SaveDNTLD";
            this.btn_SaveDNTLD.Size = new System.Drawing.Size(248, 44);
            this.btn_SaveDNTLD.TabIndex = 6;
            this.btn_SaveDNTLD.TabStop = false;
            this.btn_SaveDNTLD.Text = "Save";
            this.btn_SaveDNTLD.UseVisualStyleBackColor = true;
            this.btn_SaveDNTLD.Click += new System.EventHandler(this.btn_SaveDNTLD_Click);
            // 
            // btn_ReadDNTLD
            // 
            this.btn_ReadDNTLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadDNTLD.Location = new System.Drawing.Point(1087, 345);
            this.btn_ReadDNTLD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ReadDNTLD.Name = "btn_ReadDNTLD";
            this.btn_ReadDNTLD.Size = new System.Drawing.Size(249, 44);
            this.btn_ReadDNTLD.TabIndex = 7;
            this.btn_ReadDNTLD.TabStop = false;
            this.btn_ReadDNTLD.Text = "Read";
            this.btn_ReadDNTLD.UseVisualStyleBackColor = true;
            this.btn_ReadDNTLD.Click += new System.EventHandler(this.btn_ReadDNTLD_Click);
            // 
            // cBox_TLD
            // 
            this.cBox_TLD.FormattingEnabled = true;
            this.cBox_TLD.Location = new System.Drawing.Point(1087, 311);
            this.cBox_TLD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox_TLD.Name = "cBox_TLD";
            this.cBox_TLD.Size = new System.Drawing.Size(248, 24);
            this.cBox_TLD.TabIndex = 8;
            this.cBox_TLD.TabStop = false;
            // 
            // cBox_DN
            // 
            this.cBox_DN.FormattingEnabled = true;
            this.cBox_DN.Location = new System.Drawing.Point(1087, 250);
            this.cBox_DN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox_DN.Name = "cBox_DN";
            this.cBox_DN.Size = new System.Drawing.Size(248, 24);
            this.cBox_DN.TabIndex = 9;
            this.cBox_DN.TabStop = false;
            // 
            // lbl_STLD
            // 
            this.lbl_STLD.AutoSize = true;
            this.lbl_STLD.Location = new System.Drawing.Point(1083, 292);
            this.lbl_STLD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_STLD.Name = "lbl_STLD";
            this.lbl_STLD.Size = new System.Drawing.Size(166, 16);
            this.lbl_STLD.TabIndex = 11;
            this.lbl_STLD.Text = "Saved Top-Level-Domain:";
            // 
            // lbl_SDN
            // 
            this.lbl_SDN.AutoSize = true;
            this.lbl_SDN.Location = new System.Drawing.Point(1083, 230);
            this.lbl_SDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SDN.Name = "lbl_SDN";
            this.lbl_SDN.Size = new System.Drawing.Size(140, 16);
            this.lbl_SDN.TabIndex = 10;
            this.lbl_SDN.Text = "Saved Domain Name:";
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.AutoSize = true;
            this.lbl_FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FilePath.Location = new System.Drawing.Point(13, 698);
            this.lbl_FilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(136, 20);
            this.lbl_FilePath.TabIndex = 12;
            this.lbl_FilePath.Text = "Path to Savefile: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1352, 727);
            this.Controls.Add(this.lbl_FilePath);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Powershell Tool";
            this.tControl_Main.ResumeLayout(false);
            this.tPage_PSOU.ResumeLayout(false);
            this.tPage_PSOU.PerformLayout();
            this.tPage_PSUser.ResumeLayout(false);
            this.tPage_PSUser.PerformLayout();
            this.tPage_PSGroup.ResumeLayout(false);
            this.tPage_PSGroup.PerformLayout();
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

