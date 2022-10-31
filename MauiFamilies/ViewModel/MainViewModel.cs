using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiFamilies.Models;
using System.Collections.ObjectModel;


namespace MauiFamilies.ViewModel {
    public partial class MainViewModel : ObservableObject {
        public MainViewModel() {
            Families = new ObservableCollection<Family>();
        }
        
        [ObservableProperty]
        ObservableCollection<Family> families;
        
        [ObservableProperty]
        string membersString;

        [RelayCommand]
        void Add() {
            if ( string.IsNullOrWhiteSpace(MembersString) )
                return;
            var membersArr = MembersString.Split(',').Select(p => p.Trim()).ToList();
            
            foreach ( var member in membersArr ) {
                
                var memberArr = member.Split(" ");
                if ( memberArr.Length != 2 )
                    return;
                var FirstName = memberArr [0];
                var LastName = memberArr [1];
                var newMember = new FamilyMember() { FirstName= FirstName, LastName = LastName };
                // check if Items contains family with last name, if not create one
                var family = Families.FirstOrDefault(p => p.LastName == LastName);
                if ( family == null ) {
                    family = new Family() { LastName = LastName };
                    Families.Add(family);
                }
                if ( family.FamilyMembers.Any(m => m.FirstName == newMember.FirstName) ) {
                    return;
                }
                family.FamilyMembers.Add(newMember);
               
            }
           

            MembersString = string.Empty;
        }

        [RelayCommand]
        void Delete( Family f ) {
            if ( Families.Contains(f) ) {
                Families.Remove(f);
            }
        }
    }

}
