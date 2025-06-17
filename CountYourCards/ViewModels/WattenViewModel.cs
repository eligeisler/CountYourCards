using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CountYourCards.Models;
using CountYourCards.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountYourCards.ViewModels
{
    public partial class WattenViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _teamName1 = "";
        
        [ObservableProperty]
        private string _teamName2 = "";

        [ObservableProperty]
        private bool _visible1;
        [ObservableProperty]
        private bool _visible2;

        [ObservableProperty]
        private ObservableCollection<int> _team1Pos = new ObservableCollection<int>();
        [ObservableProperty]
        private ObservableCollection<int> _team2Pos = new ObservableCollection<int>();

        private readonly DbManagerSQLite _dbManagerSQLite;

        public WattenViewModel(DbManagerSQLite dbManagerSQLite)
        {
            this._dbManagerSQLite = dbManagerSQLite;
        }

        private async Task AddPointsToTeam1(int points)
        {
            Team1Pos.Add(points);

            if(Team1Pos.Sum() >= 9)
            {
                Visible1 = true;
            }
            if (Team1Pos.Sum() >= 11) { 
                await Shell.Current.DisplayAlert("Spiel vorbei", "Team 1 hat gewonnen", "Schließen");
                Team1Pos.Clear();
                Team2Pos.Clear();
                Visible2 = false;
                Visible1 = false;
            }
        }
        
        private async Task AddPointsToTeam2(int points)
        {
            Team2Pos.Add(points);
            if (Team2Pos.Sum() >= 9)
            {
                Visible2 = true;
            }
            if (Team2Pos.Sum() >= 11)
            {
                await Shell.Current.DisplayAlert("Spiel vorbei", "Team 2 hat gewonnen", "Schließen");
                Team2Pos.Clear();
                Team1Pos.Clear();
                Visible1 = false;
                Visible2 = false;
            }
        }

        [RelayCommand]
        public async Task Start()
        {
            Team1Pos.Clear();
            Team2Pos.Clear();
            Visible1 = false;
            Visible2 = false;
        }

        // Team 1 Commands
        [RelayCommand]
        public async Task Zwei()=> AddPointsToTeam1(2);

        [RelayCommand]
        public async Task Drei() => AddPointsToTeam1(3);

        [RelayCommand]
        public async Task Vier() => AddPointsToTeam1(4);

        [RelayCommand]
        public async Task Fuenf() => AddPointsToTeam1(5);

        [RelayCommand]
        public async Task Sechs() => AddPointsToTeam1(6);

        [RelayCommand]
        public async Task Sieben() => AddPointsToTeam1(7);

        [RelayCommand]
        public async Task Acht() => AddPointsToTeam1(8);

        [RelayCommand]
        public async Task Neun() => AddPointsToTeam1(9);

        [RelayCommand]
        public async Task Zehn() => AddPointsToTeam1(10);

        [RelayCommand]
        public async Task Elf() => AddPointsToTeam1(11);

        // Team 2 Commands
        [RelayCommand]
        public async Task RechtsZwei() => AddPointsToTeam2(2);

        [RelayCommand]
        public async Task RechtsDrei() => AddPointsToTeam2(3);

        [RelayCommand]
        public async Task RechtsVier() => AddPointsToTeam2(4);

        [RelayCommand]
        public async Task RechtsFuenf() => AddPointsToTeam2(5);

        [RelayCommand]
        public async Task RechtsSechs() => AddPointsToTeam2(6);

        [RelayCommand]
        public async Task RechtsSieben() => AddPointsToTeam2(7);

        [RelayCommand]
        public async Task RechtsAcht() => AddPointsToTeam2(8);

        [RelayCommand]
        public async Task RechtsNeun() => AddPointsToTeam2(9);

        [RelayCommand]
        public async Task RechtsZehn() => AddPointsToTeam2(10);

        [RelayCommand]
        public async Task RechtsElf() => AddPointsToTeam2(11);

     
        [RelayCommand]
        public async Task ResetTeam1()
        {
            Team1Pos.Clear();
            Visible1 = false;
        }

        [RelayCommand]
        public async Task ResetTeam2()
        {
            Team2Pos.Clear();
            Visible2 = false;
        }
        
        [RelayCommand]
        public async Task Speichern() {
            User user = new() {
                UserId = 0,
                Name = this.Name,
                Password = this.Password
            };
            var spielstand = new Spielstand {
                Team1= Team1Pos.Sum(),
                Team2 = Team2Pos.Sum(),
                SpielstandId=0,
                User=user
            };
            
            user.Spielstände.Add(spielstand);
            this._dbManagerSQLite.Spielstände.Add(spielstand);
        }

        [RelayCommand]
        public async Task UndoTeam1()
        {
            for (int i = _team1Pos.Count - 1; i >= 0; i--)
            {
                if (_team1Pos[i] != 0)
                {
                    Team1Pos.RemoveAt(i);
                    break;
                }
            }
            if (Team1Pos.Sum() < 9)
            {
                Visible1 = false;
            }
        }

        [RelayCommand]
        public async Task UndoTeam2()
        {
            for (int i = _team2Pos.Count - 1; i >= 0; i--)
            {
                if (_team2Pos[i] != 0)
                {
                    Team2Pos.RemoveAt(i);
                    break;
                }
            }
            if (Team2Pos.Sum() < 9)
            {
                Visible2 = false;
            }
        }

    }

}