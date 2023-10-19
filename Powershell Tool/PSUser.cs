using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Powershell_Tool
{
    public class PSUser
    {
        public string Name { get; set; } // UserPrincipalName und Benutzernamen in einem
        public string GivenName { get; set; } // Vorname
        public string SurName { get; set; } // Nachname

        public string TLD { get; set; } // Top Level Domain
        public List<string> DomainName = new List<string>(); // Name der Domain
        public List<string> OrganizationalUnit = new List<string>(); // Organisationseinheit / Abteilung
        public string Path { get; set; } // Zusammensezung aus OU,DN und TLD



        public PSUser() { }

        public PSUser(string pName, string pGivenName, string pSurName, string pTLD, List<string> pDN, List<string> pOU)
        {
            Name = pName;
            GivenName = pGivenName;
            SurName = pSurName;
            TLD = pTLD;
            DomainName = pDN;
            OrganizationalUnit = pOU;

            CreatePath();
        }

        public void CreatePath()
        {
            if (OrganizationalUnit.Count > 0 && DomainName.Count > 0 && TLD != "")
            {
                Path += "-Path \"";

                foreach (string OU in OrganizationalUnit)
                {
                    Path += "OU=" + OU + ",";
                }

                foreach (string DN in DomainName)
                {
                    Path += "DC=" + DN + ",";
                }

                Path += "DC=" + TLD + "\"";
            }

        }

        public override string ToString()
        {
            return $"New-ADUser -Name \"{Name}\" -UserPrincipalName \"{Name}\" -GivenName \"{GivenName}\" -Surname \"{SurName}\" {Path}";
        }
    }
}