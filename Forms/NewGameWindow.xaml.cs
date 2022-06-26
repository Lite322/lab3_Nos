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
    /// Логика взаимодействия для NewGameWindow.xaml
    /// </summary>
    public partial class NewGameWindow : Window
    {
        public NewGameWindow()
        {
            InitializeComponent();

            List<string> genderList = new List<string> { "мужской", "женский" };
            cbGender.ItemsSource = genderList;
            cbGender.SelectedIndex = 0;
        }

        private void btCreateGame_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbAge.Text))
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                Model.Gamer gamer = new Model.Gamer();
                gamer.Name = tbName.Text;
                gamer.Age = Convert.ToInt32(tbAge.Text);
                gamer.Gender = (string)cbGender.SelectedValue;

                gamer.Satiety = 100;
                gamer.Fatigue = 0;
                gamer.Money = 100;
                gamer.Day = 0;
                App.myGamer = gamer;

                Model.Guitar guitar = new Model.Guitar();
                guitar.Neck = 1;
                guitar.Pegs = 1;
                guitar.Strings = 1;
                guitar.Vocalist = 1;
                guitar.Body = 1;
                guitar.Frets = 1;
                guitar.Bridge = 1;
                guitar.Selector = 1;
                App.myGuitar = guitar;

                Model.Work work = new Model.Work();
                work.Name = "Безработный";
                work.Experience = 0;
                work.Wages = 0;
                work.UpExperience = 0;
                App.myWork = work;

                if (Convert.ToInt32(tbAge.Text) >= 18 && Convert.ToInt32(tbAge.Text) <= 120)
                {
                    Forms.GameWindow gameWindow = new GameWindow();
                    gameWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Введите корректный возраст!");
                }
            }
        }
    }
}
