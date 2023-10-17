using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Powershell_Tool
{
    public partial class Form1 : Form
    {
        string sysPathName = @"%USERPROFILE%\Documents\PowerShellTool\"; //$"../../Data/{pFName}";
        string sysPath = "";
        bool readExist = false;

        List<string> DName = new List<string>();
        List<string> TLDName = new List<string>();

        public Form1()
        {
            InitializeComponent();

            cBox_DN.Enabled = false;
            cBox_TLD.Enabled = false;

            sysPath = Environment.ExpandEnvironmentVariables(sysPathName);

            Data_FolderCreation(sysPath);

            GetInfo();
        }


        // Data Operations

        public void Data_FolderCreation(string pPath)
        {
            // Specify the directory you want to manipulate.
            string path = pPath;

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    //MessageBox.Show("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                MessageBox.Show($"The directory was created successfully at {Directory.GetParent(path)} on " + Directory.GetCreationTime(path));

                // Delete the directory.
                //di.Delete();
                //MessageBox.Show("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                MessageBox.Show("The process failed: " + e.ToString());
            }
            finally {
            lbl_FilePath.Text = "Path to Savefile: " + Directory.GetParent(path);
            }
        }

        public void Data_Write(string pFName, string pContent)
        {
            string filename = sysPath + $"{pFName}";
            string content = pContent;

            StreamWriter myFile = new StreamWriter(filename, true);

            myFile.WriteLine(content);

            myFile.Close();
        }

        public void Data_Read(string pFName, int pType)
        {

            string[] zerlegung;
            string filename = sysPath + $"{pFName}";
            string content;

            if (File.Exists(filename))
            {
                StreamReader myFile = new StreamReader(filename, System.Text.Encoding.Default);

                //content = myFile.ReadToEnd();

                while (!myFile.EndOfStream)
                {
                    content = myFile.ReadLine();

                    switch (pType)
                    {
                        case 0:
                            zerlegung = content.Split(';');

                            if (zerlegung[0] != "")
                            {
                                DName.Add(zerlegung[0]);
                            }
                            if (zerlegung[1] != "")
                            {
                                TLDName.Add(zerlegung[1]);
                            }
                            break;

                        default:
                            break;

                    }
                }

                myFile.Close();
            }
            else
            {
                MessageBox.Show("File not found in " + filename, "File Not Found", MessageBoxButtons.OK);
            }
        }

        public void ClearBox(int pType)
        {
            switch (pType)
            {
                case 0:
                    cBox_DN.Items.Clear();
                    cBox_DN.Text = string.Empty;
                    cBox_TLD.Items.Clear();
                    cBox_TLD.Text = string.Empty;

                    DName.Clear();
                    TLDName.Clear();
                    break;
                case 1:
                    tBox_DN.Clear();
                    tBox_TLD.Clear();
                    break;
                case 2:
                    tBox_PSOUBase.Clear();
                    tBox_PSOUName.Clear();
                    chBox_PSOUDel.Checked = false;
                    break;
                case 3:
                    tBox_PSUName.Clear();
                    tBox_PSUGName.Clear();
                    tBox_PSUSName.Clear();
                    tBox_PSUOU.Clear();
                    break;
                case 4:
                    tBox_PSGName.Clear();
                    cBox_PSGCategory.Text = string.Empty;
                    cBox_PSGScope.Text = string.Empty;
                    tBox_PSGOU.Clear();
                    break;


                default:
                    break;
            }
        }

        private void GetInfo()
        {
            cBox_PSGCategory.Items.Add("Security");
            cBox_PSGCategory.Items.Add("Distribution");

            cBox_PSGScope.Items.Add("DomainLocal");
            cBox_PSGScope.Items.Add("Global");
            cBox_PSGScope.Items.Add("Universal");
        }

        // Form 1 Controls

        private void btn_SaveDNTLD_Click(object sender, EventArgs e)
        {
            if (tBox_TLD.Text == "")
            {
                Data_Write("Data_Distinguished_Name.txt", tBox_DN.Text + ";");
            }
            else
            {
                Data_Write("Data_Distinguished_Name.txt", tBox_DN.Text + ";" + tBox_TLD.Text);
            }
            ClearBox(1);
        }

        private void btn_ReadDNTLD_Click(object sender, EventArgs e)
        {
            ClearBox(0);

            Data_Read("Data_Distinguished_Name.txt", 0);

            if (readExist == true)
            {
                foreach (string name in DName)
                {
                    cBox_DN.Items.Add(name);
                }
                foreach (string tld in TLDName)
                {
                    cBox_TLD.Items.Add(tld);
                }

                if (cBox_DN.Items != null)
                {
                    cBox_DN.Text = cBox_DN.Items[0].ToString();
                }
                if (cBox_TLD != null)
                {
                    cBox_TLD.Text = cBox_TLD.Items[0].ToString();
                }

                if (cBox_DN.Enabled != true || cBox_TLD.Enabled != true)
                {
                    cBox_DN.Enabled = true;
                    cBox_TLD.Enabled = true;
                }
            }
        }

        // PowerShell Controls

        private void btn_CreateOU_Click(object sender, EventArgs e)
        {
            PSOU cPSOU = new PSOU();

            cPSOU.Name = tBox_PSOUName.Text;
            if (tBox_PSOUBase.Text.Contains('.') == true)
            {
                string[] zerlegung = tBox_PSOUBase.Text.Split('.');
                foreach (string z in zerlegung)
                {
                    cPSOU.OrganizationalUnit.Add(z);
                }
            }
            else if (tBox_PSOUBase.Text != "")
            {
                cPSOU.OrganizationalUnit.Add(tBox_PSOUBase.Text);
            }

            if (cBox_DN.Text.Contains('.') == true)
            {
                string[] zerlegung = cBox_DN.Text.Split('.');
                foreach (string z in zerlegung)
                {
                    cPSOU.DomainName.Add(z);
                }
            }
            else if (cBox_DN.Text != "")
            {
                cPSOU.DomainName.Add(cBox_DN.Text);
            }

            cPSOU.TLD = cBox_TLD.Text;
            cPSOU.Protected = chBox_PSOUDel.Checked;

            cPSOU.CreatePath();

            Data_Write("Data_PowerShell-Commands.txt", cPSOU.ToString());

            //ClearBox(2);
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            PSUser cPSUser = new PSUser();

            cPSUser.Name = tBox_PSUName.Text;
            cPSUser.GivenName = tBox_PSUGName.Text;
            cPSUser.SurName = tBox_PSUSName.Text;

            if (tBox_PSUOU.Text.Contains('.') == true)
            {
                string[] zerlegung = tBox_PSUOU.Text.Split('.');
                foreach (string z in zerlegung)
                {
                    cPSUser.OrganizationalUnit.Add(z);
                }
            }
            else if (tBox_PSOUBase.Text != "")
            {
                cPSUser.OrganizationalUnit.Add(tBox_PSUOU.Text);
            }

            if (cBox_DN.Text.Contains('.') == true)
            {
                string[] zerlegung = cBox_DN.Text.Split('.');
                foreach (string z in zerlegung)
                {
                    cPSUser.DomainName.Add(z);
                }
            }
            else if (cBox_DN.Text != "")
            {
                cPSUser.DomainName.Add(cBox_DN.Text);
            }

            cPSUser.TLD = cBox_TLD.Text;

            cPSUser.CreatePath();

            Data_Write("Data_PowerShell-Commands.txt", cPSUser.ToString());

            //ClearBox(3);
        }

        private void btn_CreateGroup_Click(object sender, EventArgs e)
        {
            PSGroup cPSGroup = new PSGroup();

            cPSGroup.Name = tBox_PSGName.Text;
            cPSGroup.GroupCategory = cBox_PSGCategory.Text;
            cPSGroup.GroupScope = cBox_PSGScope.Text;

            if (tBox_PSGOU.Text.Contains('.') == true)
            {
                string[] zerlegung = tBox_PSGOU.Text.Split('.');
                foreach (string z in zerlegung)
                {
                    cPSGroup.OrganizationalUnit.Add(z);
                }
            }
            else if (tBox_PSGOU.Text != "")
            {
                cPSGroup.OrganizationalUnit.Add(tBox_PSGOU.Text);
            }
            if (cBox_DN.Text.Contains('.') == true)
            {
                string[] zerlegung = cBox_DN.Text.Split('.');
                foreach (string z in zerlegung)
                {
                    cPSGroup.DomainName.Add(z);
                }
            }
            else if (cBox_DN.Text != "")
            {
                cPSGroup.DomainName.Add(cBox_DN.Text);
            }

            cPSGroup.TLD = cBox_TLD.Text;

            cPSGroup.CreatePath();

            Data_Write("Data_PowerShell-Commands.txt", cPSGroup.ToString());

            //ClearBox(4);
        }
    }
}
