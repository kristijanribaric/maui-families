using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiFamilies.Models {
    public class Family : ObservableObject {
        public string LastName {
            get; set;
        }
        public ObservableCollection<FamilyMember> FamilyMembers {
            get; set;
        } = new ObservableCollection<FamilyMember>();
    }
}
