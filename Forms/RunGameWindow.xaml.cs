using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab3_Nos.Forms
{
    /// <summary>
    /// Логика взаимодействия для RunGameWindow.xaml
    /// </summary>
    public partial class RunGameWindow : Window
    {
        public RunGameWindow()
        {
            InitializeComponent();

            Loaded += RunGameWindow_Loaded;
        }

        private void RunGameWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MySqlLiteContext mySqlLiteContext = new DB.MySqlLiteContext();
                var gamer = mySqlLiteContext.Gamers.ToList();
                var guitar = mySqlLiteContext.Guitars.ToList();
                var work = mySqlLiteContext.Works.ToList();
                dgListGame.ItemsSource = gamer;
                dgListGuitar.ItemsSource = guitar;
                dgListWork.ItemsSource = work;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRunGame_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer = (Model.Gamer)dgListGame.SelectedItem;
            App.myGuitar = (Model.Guitar)dgListGuitar.SelectedItem;
            App.myWork = (Model.Work)dgListWork.SelectedItem;

            if (App.myGamer.GamerId == App.myGuitar.GuitarId)
            {
                if (App.myGamer.GamerId == App.myWork.WorkId)
                {
                    GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Выберете поля с одинаковым id");
                }
            }
            else
            {
                MessageBox.Show("Выберете поля с одинаковым id");
            }
        }
    }
}
