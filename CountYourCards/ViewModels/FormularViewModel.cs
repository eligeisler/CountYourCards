using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountYourCards.ViewModels
{
    public partial class FormularViewModel : ObservableObject {

        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private string _password;
        
        [RelayCommand]
        public async Task Login() {

        }
        [RelayCommand]
        public async Task Delete() {
            this.Name = "";
            this.Password = "";
        }
        public async Task Create() {

        }
    }

}
