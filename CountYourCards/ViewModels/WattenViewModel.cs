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
namespace CountYourCards.ViewModels {
    public partial class WattenViewModel : ObservableObject {

        [ObservableProperty]
        private int[] _team1Pos=new int[5];
        [ObservableProperty]
        private int[] _team2Pos=new int[5];


        private readonly DbManagerSQLite _dbManagerSQLite;
        public WattenViewModel(DbManagerSQLite dbManagerSQLite) {
            this._dbManagerSQLite = dbManagerSQLite;
        }
        
        [RelayCommand]

        public async Task Zwei() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team1Pos[i] == 0) {
                    _team1Pos[i] = 2;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task Drei() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team1Pos[i] == 0) {
                    _team1Pos[i] = 3;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task Vier() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team1Pos[i] == 0) {
                    _team1Pos[i] = 4;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task Fünf() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team1Pos[i] == 0) {
                    _team1Pos[i] = 5;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task Sechs() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team1Pos[i] == 0) {
                    _team1Pos[i] = 6;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task Sieben() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team1Pos[i] == 0) {
                    _team1Pos[i] = 7;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task Acht() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team1Pos[i] == 0) {
                    _team1Pos[i] = 8;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task Neun() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team1Pos[i] == 0) {
                    _team1Pos[i] = 9;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task Zehn() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team1Pos[i] == 0) {
                    _team1Pos[i] = 10;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task Elf() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team1Pos[i] == 0) {
                    _team1Pos[i] = 11;
                    break;
                }
            }

        }
        [RelayCommand]


        public async Task RechtsZwei() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team2Pos[i] == 0) {
                    _team2Pos[i] = 2;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task RechtsDrei() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team2Pos[i] == 0) {
                    _team2Pos[i] = 3;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task RechtsVier() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team2Pos[i] == 0) {
                    _team2Pos[i] = 4;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task RechtsFünf() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team2Pos[i] == 0) {
                    _team2Pos[i] = 5;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task RechtsSechs() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team2Pos[i] == 0) {
                    _team2Pos[i] = 6;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task RechtsSieben() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team2Pos[i] == 0) {
                    _team2Pos[i] = 7;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task RechtsAcht() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team2Pos[i] == 0) {
                    _team2Pos[i] = 8;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task RechtsNeun() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team2Pos[i] == 0) {
                    _team2Pos[i] = 9;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task RechtsZehn() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team2Pos[i] == 0) {
                    _team2Pos[i] = 10;
                    break;
                }
            }
        }
        [RelayCommand]

        public async Task RechtsElf() {
            for (int i = 0; i < _team1Pos.Length; i++) {
                if (_team2Pos[i] == 0) {
                    _team2Pos[i] = 11;
                    break;
                }
            }
        }





    }

}