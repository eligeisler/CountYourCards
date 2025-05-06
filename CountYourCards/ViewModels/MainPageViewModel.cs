using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountYourCards.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task GoToLoginPage()
        {
            await Shell.Current.GoToAsync("//Formular");
        }
    }
}
