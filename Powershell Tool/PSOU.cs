using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Powershell_Tool
{
    public class PSOU
    {
        public string Name { get; set; } // Name for the OrganizationalUnit

        public string TLD { get; set; } // Top Level Domain
        public List<string> DomainName = new List<string>(); // Name der Domain
        public List<string> OrganizationalUnit = new List<string>(); // Organisationseinheit / Abteilung
        public string Path { get; set; } // Zusammensezung aus OU,DN und TLD
        public bool Protected { get; set; } // Vor versehentlichem Löschen Schützen



        public PSOU() { }

        public PSOU(string pName, string pTLD, bool pProtect, List<string> pDN, List<string> pOU)
        {
            Name = pName;
            TLD = pTLD;
            Protected = pProtect;
            DomainName = pDN;
            OrganizationalUnit = pOU;

            CreatePath();
        }

        public void CreatePath()
        {
            if (TLD != "")
            {
                Path += "-Path \"";
            }

            foreach (string OU in OrganizationalUnit)
            {
                Path += "OU=" + OU + ",";
            }

            foreach (string DN in DomainName)
            {
                Path += "DC=" + DN + ",";
            }

            if (TLD != "")
            {
                Path += "DC=" + TLD + "\"";
            }
        }

        public override string ToString()
        {
            return $"New-ADOrganizationalUnit -Name \"{Name}\" {Path} -ProtectedFromAccidentalDeletion ${Protected.ToString().ToLowerInvariant()}";
        }
    }
}