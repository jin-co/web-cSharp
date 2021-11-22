using PharmacyApp_Week11_Final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyApp_Week11_Final.Helpers
{
    public static class PatientHelper
    {
        public static List<NameGroupFilter> GetNameGroupFilters()
        {
            List<NameGroupFilter> nameGroupList = new List<NameGroupFilter>();
            
            nameGroupList.Add(new NameGroupFilter() { NameGroupId = 1, GroupName = "A - E", LowerLetter = 'A', UpperLetter = 'E' });
            nameGroupList.Add(new NameGroupFilter() { NameGroupId = 2, GroupName = "F - K", LowerLetter = 'F', UpperLetter = 'K' });
            nameGroupList.Add(new NameGroupFilter() { NameGroupId = 3, GroupName = "L - R", LowerLetter = 'L', UpperLetter = 'R' });
            nameGroupList.Add(new NameGroupFilter() { NameGroupId = 4, GroupName = "S - Z", LowerLetter = 'S', UpperLetter = 'Z' });

            return nameGroupList;
        }
    }
}
