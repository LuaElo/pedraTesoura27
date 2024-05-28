using CommunityToolkit.Mvvm.ComponentModel;
using papelTesouraPedra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papelTesouraPedra.ViewModel
{
    public partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _nome;

        [ObservableProperty]
        private int _score;

        [ObservableProperty]
        private string _playerImage;

        [ObservableProperty]
        private string _enemyImage;

        [ObservableProperty]
        private string _result;

        [ObservableProperty]
        private string _playe;

  
         Player player = new Player();

        public Choice PlayerChoice { get; private set; }

        public void Play()
        {
            Player enemy = new Player();
            enemy.MakerChoice();
            player.Choice = PlayerChoice;
            if ( enemy.Choice == player.Choice)
            {
                Result = "Empatou"
            }

        }
        GameViewModel() { 
            Player player = new Player();
        }
    }
}
