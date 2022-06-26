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
    /// Логика взаимодействия для GuitarWindow.xaml
    /// </summary>
    public partial class GuitarWindow : Window
    {
        Model.Guitar Guitar;
        Model.Gamer Gamer;
        Model.Work Work;
        public GuitarWindow()
        {
            InitializeComponent();

            Guitar = App.myGuitar;
            gridGuitarInfo.DataContext = Guitar;

            Gamer = App.myGamer;
            tbInfoFat.DataContext = Gamer;

            Work = App.myWork;
            tbInfoExp.DataContext = Work;
        }

        private void btUpgrade1_Click(object sender, RoutedEventArgs e)
        {
            if (Guitar.Neck == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Guitar.Neck += 1;
                    gridGuitarInfo.DataContext = null;
                    gridGuitarInfo.DataContext = Guitar;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade2_Click(object sender, RoutedEventArgs e)
        {
            if (Guitar.Pegs == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Guitar.Pegs += 1;
                    gridGuitarInfo.DataContext = null;
                    gridGuitarInfo.DataContext = Guitar;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade3_Click(object sender, RoutedEventArgs e)
        {
            if (Guitar.Strings == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Guitar.Strings += 1;
                    gridGuitarInfo.DataContext = null;
                    gridGuitarInfo.DataContext = Guitar;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade4_Click(object sender, RoutedEventArgs e)
        {
            if (Guitar.Vocalist == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Guitar.Vocalist += 1;
                    gridGuitarInfo.DataContext = null;
                    gridGuitarInfo.DataContext = Guitar;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade5_Click(object sender, RoutedEventArgs e)
        {
            if (Guitar.Body == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Guitar.Body += 1;
                    gridGuitarInfo.DataContext = null;
                    gridGuitarInfo.DataContext = Guitar;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }

        }

        private void btUpgrade6_Click(object sender, RoutedEventArgs e)
        {
            if (Guitar.Frets == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Guitar.Frets += 1;
                    gridGuitarInfo.DataContext = null;
                    gridGuitarInfo.DataContext = Guitar;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade7_Click(object sender, RoutedEventArgs e)
        {
            if (Guitar.Bridge == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Guitar.Bridge += 1;
                    gridGuitarInfo.DataContext = null;
                    gridGuitarInfo.DataContext = Guitar;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btUpgrade8_Click(object sender, RoutedEventArgs e)
        {
            if (Guitar.Selector == 5)
            {
                MessageBox.Show("Невозможно улучшить! Достигнут максимальный уровень");
            }
            else
            {
                if (App.myGamer.Money >= 1000)
                {
                    Guitar.Selector += 1;
                    gridGuitarInfo.DataContext = null;
                    gridGuitarInfo.DataContext = Guitar;
                    App.myGamer.Money -= 1000;
                }

                else
                {
                    MessageBox.Show("Недостаточно денег");
                }
            }
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            Close();
        }

        private void btTune_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer.Fatigue += 25;
            App.myWork.Experience += 10;
            tbInfoFat.DataContext = null;
            tbInfoFat.DataContext = Gamer;
            tbInfoExp.DataContext = null;
            tbInfoExp.DataContext = Work;
            MessageBox.Show("Вы заполнили журнал");
            if (App.myGuitar.Neck == 2 && App.myGuitar.Pegs == 2 && App.myGuitar.Strings == 2 && App.myGuitar.Vocalist == 2 &&
                App.myGuitar.Body == 2 && App.myGuitar.Frets == 2 && App.myGuitar.Bridge == 2 && App.myGuitar.Selector == 2)
            {
                App.myGamer.Fatigue -= 3;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myGuitar.Neck == 3 && App.myGuitar.Pegs == 3 && App.myGuitar.Strings == 3 && App.myGuitar.Vocalist == 3 &&
                App.myGuitar.Body == 3 && App.myGuitar.Frets == 3 && App.myGuitar.Bridge == 3 && App.myGuitar.Selector == 3)
            {
                App.myGamer.Fatigue -= 5;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myGuitar.Neck == 4 && App.myGuitar.Pegs == 4 && App.myGuitar.Strings == 4 && App.myGuitar.Vocalist == 4 &&
                App.myGuitar.Body == 4 && App.myGuitar.Frets == 4 && App.myGuitar.Bridge == 4 && App.myGuitar.Selector == 4)
            {
                App.myGamer.Fatigue -= 10;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myGuitar.Neck == 5 && App.myGuitar.Pegs == 5 && App.myGuitar.Strings == 5 && App.myGuitar.Vocalist == 5 &&
                App.myGuitar.Body == 5 && App.myGuitar.Frets == 5 && App.myGuitar.Bridge == 5 && App.myGuitar.Selector == 5)
            {
                App.myGamer.Fatigue -= 15;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
        }

        private void btClean_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer.Fatigue += 50;
            App.myWork.Experience += 25;
            tbInfoFat.DataContext = null;
            tbInfoFat.DataContext = Gamer;
            tbInfoExp.DataContext = null;
            tbInfoExp.DataContext = Work;
            MessageBox.Show("Вы прочитали учебник по анатомии");
            if (App.myGuitar.Neck == 2 && App.myGuitar.Pegs == 2 && App.myGuitar.Strings == 2 && App.myGuitar.Vocalist == 2 &&
                App.myGuitar.Body == 2 && App.myGuitar.Frets == 2 && App.myGuitar.Bridge == 2 && App.myGuitar.Selector == 2)
            {
                App.myGamer.Fatigue -= 3;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myGuitar.Neck == 3 && App.myGuitar.Pegs == 3 && App.myGuitar.Strings == 3 && App.myGuitar.Vocalist == 3 &&
                App.myGuitar.Body == 3 && App.myGuitar.Frets == 3 && App.myGuitar.Bridge == 3 && App.myGuitar.Selector == 3)
            {
                App.myGamer.Fatigue -= 5;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myGuitar.Neck == 4 && App.myGuitar.Pegs == 4 && App.myGuitar.Strings == 4 && App.myGuitar.Vocalist == 4 &&
                App.myGuitar.Body == 4 && App.myGuitar.Frets == 4 && App.myGuitar.Bridge == 4 && App.myGuitar.Selector == 4)
            {
                App.myGamer.Fatigue -= 10;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myGuitar.Neck == 5 && App.myGuitar.Pegs == 5 && App.myGuitar.Strings == 5 && App.myGuitar.Vocalist == 5 &&
                App.myGuitar.Body == 5 && App.myGuitar.Frets == 5 && App.myGuitar.Bridge == 5 && App.myGuitar.Selector == 5)
            {
                App.myGamer.Fatigue -= 15;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
        }

        private void btCheck_Click(object sender, RoutedEventArgs e)
        {
            App.myGamer.Fatigue += 75;
            App.myWork.Experience += 50;
            tbInfoFat.DataContext = null;
            tbInfoFat.DataContext = Gamer;
            tbInfoExp.DataContext = null;
            tbInfoExp.DataContext = Work;
            MessageBox.Show("Вы выучили новые определения");
            if (App.myGuitar.Neck == 2 && App.myGuitar.Pegs == 2 && App.myGuitar.Strings == 2 && App.myGuitar.Vocalist == 2 &&
                App.myGuitar.Body == 2 && App.myGuitar.Frets == 2 && App.myGuitar.Bridge == 2 && App.myGuitar.Selector == 2)
            {
                App.myGamer.Fatigue -= 3;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myGuitar.Neck == 3 && App.myGuitar.Pegs == 3 && App.myGuitar.Strings == 3 && App.myGuitar.Vocalist == 3 &&
                App.myGuitar.Body == 3 && App.myGuitar.Frets == 3 && App.myGuitar.Bridge == 3 && App.myGuitar.Selector == 3)
            {
                App.myGamer.Fatigue -= 5;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myGuitar.Neck == 4 && App.myGuitar.Pegs == 4 && App.myGuitar.Strings == 4 && App.myGuitar.Vocalist == 4 &&
                App.myGuitar.Body == 4 && App.myGuitar.Frets == 4 && App.myGuitar.Bridge == 4 && App.myGuitar.Selector == 4)
            {
                App.myGamer.Fatigue -= 10;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
            else if (App.myGuitar.Neck == 5 && App.myGuitar.Pegs == 5 && App.myGuitar.Strings == 5 && App.myGuitar.Vocalist == 5 &&
                App.myGuitar.Body == 5 && App.myGuitar.Frets == 5 && App.myGuitar.Bridge == 5 && App.myGuitar.Selector == 5)
            {
                App.myGamer.Fatigue -= 15;
                tbInfoFat.DataContext = null;
                tbInfoFat.DataContext = Gamer;
                tbInfoExp.DataContext = null;
                tbInfoExp.DataContext = Work;
            }
        }
    }
}
