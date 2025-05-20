using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CountYourCards.Models;
using CountYourCards.Services;
using Microsoft.EntityFrameworkCore;
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

        private readonly DbManagerSQLite _dbManagerSQLite;
        public FormularViewModel(DbManagerSQLite dbManagerSQLite) {
            this._dbManagerSQLite = dbManagerSQLite;
        }
            [RelayCommand]
        public async Task Login() {
            
            User? u= await this._dbManagerSQLite.Users.FirstOrDefaultAsync(u => u.Name ==this.Name &&
            u.Password==this.Password );
            if(u is null) {
                await Shell.Current.DisplayAlert("Kein User gefunden", "Password oder Name falsch", "OK");
            }
            else {
                Clearfields();

            }
            
        }
        [RelayCommand]
        public async Task Delete() {
            Clearfields();
            
        }
        [RelayCommand]
        public async Task Create() {
            User user = new() {
                UserId = 0,
                Name = this.Name,
                Password = this.Password
            };
            /*
            Spielstand sp = new Spielstand() {
                SpielstandId = 1,
                Team1 = 2,
                Team2 = 4,
                User = user
            };
            user.Spielstände.Add(sp);
            this._dbManagerSQLite.Spielstände.Add(sp);*/
           
            this._dbManagerSQLite.Users.Add(user);
            await this._dbManagerSQLite.SaveChangesAsync();
            Clearfields();
        }

        private void Clearfields() {
            this.Name = "";
            this.Password = "";
        }

     } 
    }
