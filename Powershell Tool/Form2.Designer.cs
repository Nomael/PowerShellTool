namespace Powershell_Tool
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tLPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_HeadName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_FilePath = new System.Windows.Forms.Label();
            this.tControl_Main = new System.Windows.Forms.TabControl();
            this.tPage_PSOU = new System.Windows.Forms.TabPage();
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
            this.tPage_login = new System.Windows.Forms.TabPage();
            this.lbl_OUName = new System.Windows.Forms.Label();
            this.chBox_PSOUDel = new System.Windows.Forms.CheckBox();
            this.tBox_PSOUName = new System.Windows.Forms.TextBox();
            this.btn_CreateOU = new System.Windows.Forms.Button();
            this.tBox_PSOUBase = new System.Windows.Forms.TextBox();
            this.lbl_OUBase = new System.Windows.Forms.Label();
            this.tLPanel_Main.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tControl_Main.SuspendLayout();
            this.tPage_PSOU.SuspendLayout();
            this.tPage_PSUser.SuspendLayout();
            this.tPage_PSGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPanel_Main
            // 
            this.tLPanel_Main.ColumnCount = 1;
            this.tLPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanel_Main.Controls.Add(this.panel_Header, 0, 0);
            this.tLPanel_Main.Controls.Add(this.panel1, 0, 1);
            this.tLPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tLPanel_Main.Name = "tLPanel_Main";
            this.tLPanel_Main.RowCount = 2;
            this.tLPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPanel_Main.Size = new System.Drawing.Size(849, 428);
            this.tLPanel_Main.TabIndex = 0;
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_Header.Controls.Add(this.lbl_HeadName);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Header.Location = new System.Drawing.Point(3, 3);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(843, 49);
            this.panel_Header.TabIndex = 0;
            // 
            // lbl_HeadName
            // 
            this.lbl_HeadName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_HeadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HeadName.ForeColor = System.Drawing.Color.White;
            this.lbl_HeadName.Location = new System.Drawing.Point(0, 0);
            this.lbl_HeadName.Name = "lbl_HeadName";
            this.lbl_HeadName.Size = new System.Drawing.Size(843, 49);
            this.lbl_HeadName.TabIndex = 0;
            this.lbl_HeadName.Text = "Powershell Tool";
            this.lbl_HeadName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tControl_Main);
            this.panel1.Controls.Add(this.lbl_FilePath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 367);
            this.panel1.TabIndex = 1;
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.AutoSize = true;
            this.lbl_FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FilePath.Location = new System.Drawing.Point(3, 344);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(115, 17);
            this.lbl_FilePath.TabIndex = 13;
            this.lbl_FilePath.Text = "Path to Savefile: ";
            // 
            // tControl_Main
            // 
            this.tControl_Main.Controls.Add(this.tPage_PSOU);
            this.tControl_Main.Controls.Add(this.tPage_PSUser);
            this.tControl_Main.Controls.Add(this.tPage_PSGroup);
            this.tControl_Main.Controls.Add(this.tPage_login);
            this.tControl_Main.Location = new System.Drawing.Point(3, 3);
            this.tControl_Main.Name = "tControl_Main";
            this.tControl_Main.SelectedIndex = 0;
            this.tControl_Main.Size = new System.Drawing.Size(837, 338);
            this.tControl_Main.TabIndex = 0;
            this.tControl_Main.TabStop = false;
            // 
            // tPage_PSOU
            // 
            this.tPage_PSOU.BackColor = System.Drawing.Color.Transparent;
            this.tPage_PSOU.Controls.Add(this.lbl_OUBase);
            this.tPage_PSOU.Controls.Add(this.tBox_PSOUBase);
            this.tPage_PSOU.Controls.Add(this.tBox_PSOUName);
            this.tPage_PSOU.Controls.Add(this.btn_CreateOU);
            this.tPage_PSOU.Controls.Add(this.chBox_PSOUDel);
            this.tPage_PSOU.Controls.Add(this.lbl_OUName);
            this.tPage_PSOU.Location = new System.Drawing.Point(4, 22);
            this.tPage_PSOU.Name = "tPage_PSOU";
            this.tPage_PSOU.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_PSOU.Size = new System.Drawing.Size(829, 312);
            this.tPage_PSOU.TabIndex = 0;
            this.tPage_PSOU.Text = "PowerShell OU";
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
            this.tPage_PSUser.Location = new System.Drawing.Point(4, 22);
            this.tPage_PSUser.Name = "tPage_PSUser";
            this.tPage_PSUser.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_PSUser.Size = new System.Drawing.Size(829, 312);
            this.tPage_PSUser.TabIndex = 1;
            this.tPage_PSUser.Text = "PowerShell User";
            // 
            // tBox_PSUSName
            // 
            this.tBox_PSUSName.Location = new System.Drawing.Point(6, 119);
            this.tBox_PSUSName.Name = "tBox_PSUSName";
            this.tBox_PSUSName.Size = new System.Drawing.Size(262, 20);
            this.tBox_PSUSName.TabIndex = 22;
            this.tBox_PSUSName.TabStop = false;
            // 
            // lbl_SName
            // 
            this.lbl_SName.AutoSize = true;
            this.lbl_SName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SName.Location = new System.Drawing.Point(6, 96);
            this.lbl_SName.Name = "lbl_SName";
            this.lbl_SName.Size = new System.Drawing.Size(151, 17);
            this.lbl_SName.TabIndex = 21;
            this.lbl_SName.Text = "Surname (Nachname):";
            // 
            // tBox_PSUGName
            // 
            this.tBox_PSUGName.Location = new System.Drawing.Point(6, 73);
            this.tBox_PSUGName.Name = "tBox_PSUGName";
            this.tBox_PSUGName.Size = new System.Drawing.Size(262, 20);
            this.tBox_PSUGName.TabIndex = 20;
            this.tBox_PSUGName.TabStop = false;
            // 
            // lbl_GName
            // 
            this.lbl_GName.AutoSize = true;
            this.lbl_GName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GName.Location = new System.Drawing.Point(6, 50);
            this.lbl_GName.Name = "lbl_GName";
            this.lbl_GName.Size = new System.Drawing.Size(161, 17);
            this.lbl_GName.TabIndex = 19;
            this.lbl_GName.Text = "Given Name (Vorname):";
            // 
            // lbl_UOUPfad
            // 
            this.lbl_UOUPfad.AutoSize = true;
            this.lbl_UOUPfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UOUPfad.Location = new System.Drawing.Point(297, 3);
            this.lbl_UOUPfad.Name = "lbl_UOUPfad";
            this.lbl_UOUPfad.Size = new System.Drawing.Size(392, 17);
            this.lbl_UOUPfad.TabIndex = 18;
            this.lbl_UOUPfad.Text = "Path to Organizational Unit (OU / OU.ParentOU.ParentOU...)";
            // 
            // tBox_PSUOU
            // 
            this.tBox_PSUOU.Location = new System.Drawing.Point(300, 26);
            this.tBox_PSUOU.Name = "tBox_PSUOU";
            this.tBox_PSUOU.Size = new System.Drawing.Size(427, 20);
            this.tBox_PSUOU.TabIndex = 17;
            this.tBox_PSUOU.TabStop = false;
            // 
            // tBox_PSUName
            // 
            this.tBox_PSUName.Location = new System.Drawing.Point(6, 26);
            this.tBox_PSUName.Name = "tBox_PSUName";
            this.tBox_PSUName.Size = new System.Drawing.Size(262, 20);
            this.tBox_PSUName.TabIndex = 16;
            this.tBox_PSUName.TabStop = false;
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.Location = new System.Drawing.Point(6, 3);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(165, 17);
            this.lbl_UName.TabIndex = 15;
            this.lbl_UName.Text = "Username / Login Name:";
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateUser.Location = new System.Drawing.Point(6, 145);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(173, 36);
            this.btn_CreateUser.TabIndex = 13;
            this.btn_CreateUser.TabStop = false;
            this.btn_CreateUser.Text = "Create";
            this.btn_CreateUser.UseVisualStyleBackColor = true;
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
            this.tPage_PSGroup.Location = new System.Drawing.Point(4, 22);
            this.tPage_PSGroup.Name = "tPage_PSGroup";
            this.tPage_PSGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_PSGroup.Size = new System.Drawing.Size(829, 312);
            this.tPage_PSGroup.TabIndex = 2;
            this.tPage_PSGroup.Text = "PowerShell Group";
            // 
            // cBox_PSGScope
            // 
            this.cBox_PSGScope.FormattingEnabled = true;
            this.cBox_PSGScope.Location = new System.Drawing.Point(6, 116);
            this.cBox_PSGScope.Name = "cBox_PSGScope";
            this.cBox_PSGScope.Size = new System.Drawing.Size(262, 21);
            this.cBox_PSGScope.TabIndex = 31;
            this.cBox_PSGScope.TabStop = false;
            // 
            // cBox_PSGCategory
            // 
            this.cBox_PSGCategory.FormattingEnabled = true;
            this.cBox_PSGCategory.Location = new System.Drawing.Point(6, 70);
            this.cBox_PSGCategory.Name = "cBox_PSGCategory";
            this.cBox_PSGCategory.Size = new System.Drawing.Size(262, 21);
            this.cBox_PSGCategory.TabIndex = 12;
            this.cBox_PSGCategory.TabStop = false;
            // 
            // lbl_PSGScope
            // 
            this.lbl_PSGScope.AutoSize = true;
            this.lbl_PSGScope.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PSGScope.Location = new System.Drawing.Point(6, 96);
            this.lbl_PSGScope.Name = "lbl_PSGScope";
            this.lbl_PSGScope.Size = new System.Drawing.Size(96, 17);
            this.lbl_PSGScope.TabIndex = 30;
            this.lbl_PSGScope.Text = "Group Scope:";
            // 
            // lbl_PSGCategory
            // 
            this.lbl_PSGCategory.AutoSize = true;
            this.lbl_PSGCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PSGCategory.Location = new System.Drawing.Point(6, 50);
            this.lbl_PSGCategory.Name = "lbl_PSGCategory";
            this.lbl_PSGCategory.Size = new System.Drawing.Size(113, 17);
            this.lbl_PSGCategory.TabIndex = 28;
            this.lbl_PSGCategory.Text = "Group Category:";
            // 
            // lbl_PSGOU
            // 
            this.lbl_PSGOU.AutoSize = true;
            this.lbl_PSGOU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PSGOU.Location = new System.Drawing.Point(297, 3);
            this.lbl_PSGOU.Name = "lbl_PSGOU";
            this.lbl_PSGOU.Size = new System.Drawing.Size(392, 17);
            this.lbl_PSGOU.TabIndex = 27;
            this.lbl_PSGOU.Text = "Path to Organizational Unit (OU / OU.ParentOU.ParentOU...)";
            // 
            // tBox_PSGOU
            // 
            this.tBox_PSGOU.Location = new System.Drawing.Point(300, 26);
            this.tBox_PSGOU.Name = "tBox_PSGOU";
            this.tBox_PSGOU.Size = new System.Drawing.Size(427, 20);
            this.tBox_PSGOU.TabIndex = 26;
            this.tBox_PSGOU.TabStop = false;
            // 
            // tBox_PSGName
            // 
            this.tBox_PSGName.Location = new System.Drawing.Point(6, 23);
            this.tBox_PSGName.Name = "tBox_PSGName";
            this.tBox_PSGName.Size = new System.Drawing.Size(262, 20);
            this.tBox_PSGName.TabIndex = 25;
            this.tBox_PSGName.TabStop = false;
            // 
            // lbl_PSGName
            // 
            this.lbl_PSGName.AutoSize = true;
            this.lbl_PSGName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PSGName.Location = new System.Drawing.Point(6, 3);
            this.lbl_PSGName.Name = "lbl_PSGName";
            this.lbl_PSGName.Size = new System.Drawing.Size(93, 17);
            this.lbl_PSGName.TabIndex = 24;
            this.lbl_PSGName.Text = "Group Name:";
            // 
            // btn_CreateGroup
            // 
            this.btn_CreateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateGroup.Location = new System.Drawing.Point(6, 145);
            this.btn_CreateGroup.Name = "btn_CreateGroup";
            this.btn_CreateGroup.Size = new System.Drawing.Size(173, 36);
            this.btn_CreateGroup.TabIndex = 23;
            this.btn_CreateGroup.TabStop = false;
            this.btn_CreateGroup.Text = "Create";
            this.btn_CreateGroup.UseVisualStyleBackColor = true;
            // 
            // tPage_login
            // 
            this.tPage_login.Location = new System.Drawing.Point(4, 22);
            this.tPage_login.Name = "tPage_login";
            this.tPage_login.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_login.Size = new System.Drawing.Size(829, 312);
            this.tPage_login.TabIndex = 3;
            this.tPage_login.Text = "Login";
            this.tPage_login.UseVisualStyleBackColor = true;
            // 
            // lbl_OUName
            // 
            this.lbl_OUName.AutoSize = true;
            this.lbl_OUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OUName.Location = new System.Drawing.Point(6, 11);
            this.lbl_OUName.Name = "lbl_OUName";
            this.lbl_OUName.Size = new System.Drawing.Size(174, 17);
            this.lbl_OUName.TabIndex = 0;
            this.lbl_OUName.Text = "Organizational Unit Name:";
            // 
            // chBox_PSOUDel
            // 
            this.chBox_PSOUDel.AutoSize = true;
            this.chBox_PSOUDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBox_PSOUDel.Location = new System.Drawing.Point(6, 72);
            this.chBox_PSOUDel.Name = "chBox_PSOUDel";
            this.chBox_PSOUDel.Size = new System.Drawing.Size(226, 21);
            this.chBox_PSOUDel.TabIndex = 1;
            this.chBox_PSOUDel.TabStop = false;
            this.chBox_PSOUDel.Text = "Protect from accidental deletion";
            this.chBox_PSOUDel.UseVisualStyleBackColor = true;
            // 
            // tBox_PSOUName
            // 
            this.tBox_PSOUName.Location = new System.Drawing.Point(6, 34);
            this.tBox_PSOUName.Name = "tBox_PSOUName";
            this.tBox_PSOUName.Size = new System.Drawing.Size(262, 20);
            this.tBox_PSOUName.TabIndex = 2;
            this.tBox_PSOUName.TabStop = false;
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
            // 
            // tBox_PSOUBase
            // 
            this.tBox_PSOUBase.Location = new System.Drawing.Point(300, 34);
            this.tBox_PSOUBase.Name = "tBox_PSOUBase";
            this.tBox_PSOUBase.Size = new System.Drawing.Size(427, 20);
            this.tBox_PSOUBase.TabIndex = 13;
            this.tBox_PSOUBase.TabStop = false;
            // 
            // lbl_OUBase
            // 
            this.lbl_OUBase.AutoSize = true;
            this.lbl_OUBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OUBase.Location = new System.Drawing.Point(297, 11);
            this.lbl_OUBase.Name = "lbl_OUBase";
            this.lbl_OUBase.Size = new System.Drawing.Size(392, 17);
            this.lbl_OUBase.TabIndex = 14;
            this.lbl_OUBase.Text = "Path to Organizational Unit (OU / OU.ParentOU.ParentOU...)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 428);
            this.Controls.Add(this.tLPanel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Powershell Tool";
            this.tLPanel_Main.ResumeLayout(false);
            this.panel_Header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tControl_Main.ResumeLayout(false);
            this.tPage_PSOU.ResumeLayout(false);
            this.tPage_PSOU.PerformLayout();
            this.tPage_PSUser.ResumeLayout(false);
            this.tPage_PSUser.PerformLayout();
            this.tPage_PSGroup.ResumeLayout(false);
            this.tPage_PSGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPanel_Main;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label lbl_HeadName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_FilePath;
        private System.Windows.Forms.TabControl tControl_Main;
        private System.Windows.Forms.TabPage tPage_PSOU;
        private System.Windows.Forms.TabPage tPage_PSUser;
        private System.Windows.Forms.TextBox tBox_PSUSName;
        private System.Windows.Forms.Label lbl_SName;
        private System.Windows.Forms.TextBox tBox_PSUGName;
        private System.Windows.Forms.Label lbl_GName;
        private System.Windows.Forms.Label lbl_UOUPfad;
        private System.Windows.Forms.TextBox tBox_PSUOU;
        private System.Windows.Forms.TextBox tBox_PSUName;
        private System.Windows.Forms.Label lbl_UName;
        private System.Windows.Forms.Button btn_CreateUser;
        private System.Windows.Forms.TabPage tPage_PSGroup;
        private System.Windows.Forms.ComboBox cBox_PSGScope;
        private System.Windows.Forms.ComboBox cBox_PSGCategory;
        private System.Windows.Forms.Label lbl_PSGScope;
        private System.Windows.Forms.Label lbl_PSGCategory;
        private System.Windows.Forms.Label lbl_PSGOU;
        private System.Windows.Forms.TextBox tBox_PSGOU;
        private System.Windows.Forms.TextBox tBox_PSGName;
        private System.Windows.Forms.Label lbl_PSGName;
        private System.Windows.Forms.Button btn_CreateGroup;
        private System.Windows.Forms.TabPage tPage_login;
        private System.Windows.Forms.Label lbl_OUBase;
        private System.Windows.Forms.TextBox tBox_PSOUBase;
        private System.Windows.Forms.TextBox tBox_PSOUName;
        private System.Windows.Forms.Button btn_CreateOU;
        private System.Windows.Forms.CheckBox chBox_PSOUDel;
        private System.Windows.Forms.Label lbl_OUName;
    }
}

