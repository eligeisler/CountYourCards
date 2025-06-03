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
        private string _teamName1 = "";

        [ObservableProperty]
        private string _teamName2 = "";

        private ObservableCollection<int> _team1Pos = new ObservableCollection<int>(new int[6]);
        private ObservableCollection<int> _team2Pos = new ObservableCollection<int>(new int[6]);

        [ObservableProperty]
        private ObservableCollection<int> _team1Position;

        [ObservableProperty]
        private ObservableCollection<int> _team2Position;

        private readonly DbManagerSQLite _dbManagerSQLite;

        public WattenViewModel(DbManagerSQLite dbManagerSQLite)
        {
            this._dbManagerSQLite = dbManagerSQLite;

            _team1Position = new ObservableCollection<int>();
            _team2Position = new ObservableCollection<int>();
        }

        private void UpdateTeam1Display()
        {
            _team1Position.Clear();
            foreach (var value in _team1Pos.Where(x => x != 0))
            {
                _team1Position.Add(value);
            }
        }

        private void UpdateTeam2Display()
        {
            _team2Position.Clear();
            foreach (var value in _team2Pos.Where(x => x != 0))
            {
                _team2Position.Add(value);
            }
        }

        private void AddPointsToTeam1(int points)
        {
            for (int i = 0; i < _team1Pos.Count; i++)
            {
                if (_team1Pos[i] == 0)
                {
                    _team1Pos[i] = points;
                    UpdateTeam1Display();
                    break;
                }
            }
        }

        private void AddPointsToTeam2(int points)
        {
            for (int i = 0; i < _team2Pos.Count; i++)
            {
                if (_team2Pos[i] == 0)
                {
                    _team2Pos[i] = points;
                    UpdateTeam2Display();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task Start()
        {
            // Reset der Punktestände
            for (int i = 0; i < _team1Pos.Count; i++)
            {
                _team1Pos[i] = 0;
                _team2Pos[i] = 0;
            }
            UpdateTeam1Display();
            UpdateTeam2Display();
        }

        // Team 1 Commands
        [RelayCommand]
        public async Task Zwei() => AddPointsToTeam1(2);

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

        // Zusätzliche Hilfsmethoden
        [RelayCommand]
        public async Task ResetTeam1()
        {
            for (int i = 0; i < _team1Pos.Count; i++)
            {
                _team1Pos[i] = 0;
            }
            UpdateTeam1Display();
        }

        [RelayCommand]
        public async Task ResetTeam2()
        {
            for (int i = 0; i < _team2Pos.Count; i++)
            {
                _team2Pos[i] = 0;
            }
            UpdateTeam2Display();
        }

        [RelayCommand]
        public async Task UndoTeam1()
        {
            for (int i = _team1Pos.Count - 1; i >= 0; i--)
            {
                if (_team1Pos[i] != 0)
                {
                    _team1Pos[i] = 0;
                    UpdateTeam1Display();
                    break;
                }
            }
        }

        [RelayCommand]
        public async Task UndoTeam2()
        {
            for (int i = _team2Pos.Count - 1; i >= 0; i--)
            {
                if (_team2Pos[i] != 0)
                {
                    _team2Pos[i] = 0;
                    UpdateTeam2Display();
                    break;
                }
            }
        }

        // Properties für Gesamtpunkte (optional)
        public int Team1Total => _team1Pos.Sum();
        public int Team2Total => _team2Pos.Sum();
    }
}