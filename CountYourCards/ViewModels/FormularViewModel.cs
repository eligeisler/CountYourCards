using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CountYourCards.Models;
using CountYourCards.Services;
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
            User user = new() {
                UserId = 0,
                Name = this.Name,
                password = this.Password
            };
            this._dbManagerSQLite.Users.Add(user);
            await this._dbManagerSQLite.SaveChangesAsync();
        }
        [RelayCommand]
        public async Task Delete() {
            this.Name = "";
            this.Password = "";

        }
        [RelayCommand]
        public async Task Create() {
            User user = new() {
                UserId = 0,
                Name = this.Name,
                password = this.Password
            };
            this._dbManagerSQLite.Users.Add(user);
            await this._dbManagerSQLite.SaveChangesAsync();
        }

     } 
    }
