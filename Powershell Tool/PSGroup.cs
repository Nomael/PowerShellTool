﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Powershell_Tool
{
    public class PSGroup
    {
        public string Name { get; set; } // Name for the Local Group
        public string GroupCategory { get; set; } // Distribution oder Security
        public string GroupScope { get; set; } // DomainLocal, Global oder Universal

        public string TLD { get; set; } // Top Level Domain
        public List<string> DomainName; // Name der Domain
        public List<string> OrganizationalUnit; // Organisationseinheit / Abteilung
        public string Path { get; set; } // Zusammensezung aus OU,DN und TLD



        public PSGroup() { }

        public PSGroup(string pName, string pGroupCategory, string pGroupScope, string pTLD, List<string> pDN, List<string> pOU)
        {
            Name = pName;
            GroupCategory = pGroupCategory;
            GroupScope = pGroupScope;
            TLD = pTLD;
            DomainName = pDN;
            OrganizationalUnit = pOU;

            CreatePath();
        }

        public void CreatePath()
        {
            foreach (string OU in OrganizationalUnit)
            {
                Path += "OU=" + OU + ",";
            }

            foreach (string DN in DomainName)
            {
                Path += "DC=" + DN + ",";
            }

            Path += "DC=" + TLD;
        }

        public override string ToString()
        {
            return $"New-ADGroup -Name \"{Name}\" -GroupCategory {GroupCategory} -GroupScope {GroupScope} -Path \"{Path}\"";
        }
    }
}