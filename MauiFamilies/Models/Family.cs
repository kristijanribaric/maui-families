using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiFamilies.Models {
    public class Family {
        public string LastName {
            get; set;
        }
        public List<FamilyMember> FamilyMembers {
            get; set;
        } = new List<FamilyMember>();
    }
}
