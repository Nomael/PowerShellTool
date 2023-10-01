using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powershell_Tool
{
    public partial class Form1 : Form
    {
        List<string> DisName = new List<string>();
        PSUser cPSUser;
        PSGroup cPSGroup;

        public Form1()
        {
            InitializeComponent();
        }


        // Data Operations

        public void Data_Write(string pFName, string pContent)
        {
            string filename = $"../../Data/{pFName}";
            string content = pContent + System.Environment.NewLine;

            StreamWriter myFile = new StreamWriter(filename, true);

            myFile.Write(content);

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

                    foreach (string z in zerlegung)
                    {
                        DisName.Add(z);
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
                    cBox_TLD.Items.Clear();
                    DisName.Clear();
                    break;
            }
        }

        // Form 1 Controls

        private void btn_SaveDNTLD_Click(object sender, EventArgs e)
        {
            Data_Write("Distinguished_Name.txt", tBox_DN.Text + ";" + tBox_TLD.Text);
            ClearBox(0);
        }

        private void btn_ReadDNTLD_Click(object sender, EventArgs e)
        {
            ClearBox(1);

            Data_Read("Distinguished_Name.txt");
            for (int i = 1; i <= DisName.Count; i += 2)
            {
                cBox_DN.Items.Add(DisName[i - 1]);
                cBox_TLD.Items.Add(DisName[i]);
            }
        }

        // PowerShell Controls

        private void btn_CreateOU_Click(object sender, EventArgs e)
        {
            PSOU cPSOU = new PSOU();

            cPSOU.Name = tbox_OUName.Text;
            cPSOU.OrganizationalUnit.Add(tBox_OUBase.Text);
            cPSOU.DomainName.Add(cBox_DN.Text);
            cPSOU.TLD = cBox_TLD.Text;
            cPSOU.Protected = chBox_PFAD.Checked;

            cPSOU.CreatePath();

            Data_Write("PowerShell Commands.txt", cPSOU.ToString());
        }
    }
}
