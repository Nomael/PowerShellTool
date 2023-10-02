using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        List<string> DName = new List<string>();
        List<string> TLDName = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


        // Data Operations

        public void Data_Write(string pFName, string pContent)
        {
            string filename = $"../../Data/{pFName}";
            string content = pContent;

            StreamWriter myFile = new StreamWriter(filename, true);

            myFile.WriteLine(content);

            myFile.Close();
        }

        public void Data_Read(string pFName)
        {
            string[] zerlegung;
            string filename = $"../../Data/{pFName}";
            string content;

            if (File.Exists(filename))
            {
                StreamReader myFile = new StreamReader(filename, System.Text.Encoding.Default);

                //content = myFile.ReadToEnd();

                while (!myFile.EndOfStream)
                {
                    content = myFile.ReadLine();
                    zerlegung = content.Split(';');

                    if (zerlegung[0] != "")
                    {
                        DName.Add(zerlegung[0]);
                    }
                    if (zerlegung[1] != "")
                    {
                        TLDName.Add(zerlegung[1]);
                    }
                }

                myFile.Close();
            }
            else
            {
                MessageBox.Show("File not found in " + filename, "File Not Found", MessageBoxButtons.OK);
            }
        }

        // QOL Features

        public void ClearBox(int pType)
        {
            switch (pType)
            {
                case 0:
                    tBox_DN.Clear();
                    tBox_TLD.Clear();
                    break;
                case 1:
                    cBox_DN.Items.Clear();
                    cBox_DN.Text = string.Empty;
                    cBox_TLD.Items.Clear();
                    cBox_TLD.Text = string.Empty;

                    DName.Clear();
                    TLDName.Clear();
                    break;
            }
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
            ClearBox(0);
        }

        private void btn_ReadDNTLD_Click(object sender, EventArgs e)
        {
            ClearBox(1);

            Data_Read("Data_Distinguished_Name.txt");

            foreach (string name in DName)
            {
                cBox_DN.Items.Add(name);
            }
            foreach (string tld in TLDName)
            {
                cBox_TLD.Items.Add(tld);
            }
        }

        // PowerShell Controls

        private void btn_CreateOU_Click(object sender, EventArgs e)
        {
            PSOU cPSOU = new PSOU();

            cPSOU.Name = tbox_PSOUName.Text;
            if (tbox_PSOUBase.Text.Contains('.') == true )
            {
                string[] zerlegung = tbox_PSOUBase.Text.Split('.');
                foreach (string z in zerlegung)
                {
                    cPSOU.OrganizationalUnit.Add(z);
                }
            }else
            {
                cPSOU.OrganizationalUnit.Add(tbox_PSOUBase.Text);
            }
            if (cBox_DN.Text.Contains('.') == true)
            {
                string[] zerlegung = cBox_DN.Text.Split('.');
                foreach (string z in zerlegung)
                {
                    cPSOU.DomainName.Add(z);
                }
            }
            else
            {
                cPSOU.DomainName.Add(cBox_DN.Text);
            }

            cPSOU.TLD = cBox_TLD.Text;
            cPSOU.Protected = chBox_PSOUDel.Checked;

            cPSOU.CreatePath();

            Data_Write("Data_PowerShell-Commands.txt", cPSOU.ToString());
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
            else
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
            else
            {
                cPSUser.DomainName.Add(cBox_DN.Text);
            }

            cPSUser.TLD = cBox_TLD.Text;

            cPSUser.CreatePath();

            Data_Write("Data_PowerShell-Commands.txt", cPSUser.ToString());
        }

        PSGroup cPSGroup;
    }
}
