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
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        Model.Gamer Gamer;
        Model.Guitar Guitar;
        Model.Work Work;
        public GameWindow()
        {
            InitializeComponent();

            Gamer = App.myGamer;
            gridInfoGamer.DataContext = Gamer;

            Guitar = App.myGuitar;
            gridGuitarInfo.DataContext = Guitar;

            Work = App.myWork;
            gridInfoWork.DataContext = Work;
        }
        private void btNextDay_Click(object sender, RoutedEventArgs e)
        {
            if (Gamer.Satiety <= 0)
            {
                MainWindow mainWindow = new MainWindow();
                MessageBox.Show("Вы умерли от голода. Дней прожито: " + App.myGamer.Day);
                mainWindow.Show();
                Close();
            }
            if (Work.Name == "Играть на остановке")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Играть на вокзале")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Играть на дне рождения")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Играть на онлайн трансляции")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Играть в группе")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Играть в мало известном баре")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Композитор")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Играть в баре 'Ну и чё'")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Играть на концерте")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            else if (Work.Name == "Давать сольные концерты")
            {
                Work.Experience += App.myWork.UpExperience;
                Gamer.Money += App.myWork.Wages;
                gridInfoWork.DataContext = null;
                gridInfoWork.DataContext = Work;
            }
            if (Gamer.Fatigue >= 100)
            {
                MessageBox.Show("Вы умерли от усталости. Дней прожито: " + Gamer.Day);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            if (Work.Experience >= 15000 && Work.Name == "Давать сольные концерты" && Guitar.Neck == 5 && Guitar.Pegs == 5 &&
                Guitar.Strings == 5 && Guitar.Vocalist == 5 && Guitar.Body == 5 && Guitar.Frets == 5 && Guitar.Bridge == 5 && Guitar.Selector == 5)
            {
                MessageBox.Show("Поздравляем, вы прошли игру! Вам понадобилось на это " + Gamer.Day + " дней");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }

            Gamer.Fatigue = 0;
            Gamer.Day += 1;
            Gamer.Satiety -= 10;
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
        }

        private void btWork_Click(object sender, RoutedEventArgs e)
        {
            WorkWindow workWindow = new WorkWindow();
            workWindow.ShowDialog();
            Close();
        }

        private void btCafe_Click(object sender, RoutedEventArgs e)
        {
            CafeWindow cafeWindow = new CafeWindow();
            cafeWindow.ShowDialog();
            Close();
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
        }

        private void btSaveGame_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Model.Gamer newGamer = new Model.Gamer();
                Model.Guitar newGuitar = new Model.Guitar();
                Model.Work newWork = new Model.Work();

                newGamer.Name = App.myGamer.Name;
                newGamer.Age = App.myGamer.Age;
                newGamer.Gender = App.myGamer.Gender;
                newGamer.Satiety = App.myGamer.Satiety;
                newGamer.Fatigue = App.myGamer.Fatigue;
                newGamer.Money = App.myGamer.Money;
                newGamer.Day = App.myGamer.Day;

                newGuitar.Neck = App.myGuitar.Neck;
                newGuitar.Pegs = App.myGuitar.Pegs;
                newGuitar.Strings = App.myGuitar.Strings;
                newGuitar.Vocalist = App.myGuitar.Vocalist;
                newGuitar.Body = App.myGuitar.Body;
                newGuitar.Frets = App.myGuitar.Frets;
                newGuitar.Bridge = App.myGuitar.Bridge;
                newGuitar.Selector = App.myGuitar.Selector;

                newWork.Name = App.myWork.Name;
                newWork.Wages = App.myWork.Wages;
                newWork.Minqualifications = App.myWork.Minqualifications;
                newWork.Experience = App.myWork.Experience;
                newWork.UpExperience = App.myWork.UpExperience;

                using DB.MySqlLiteContext mySqlLiteContext = new DB.MySqlLiteContext();
                mySqlLiteContext.Gamers.Add(newGamer);
                mySqlLiteContext.SaveChanges();
                mySqlLiteContext.Guitars.Add(newGuitar);
                mySqlLiteContext.SaveChanges();
                mySqlLiteContext.Works.Add(newWork);
                mySqlLiteContext.SaveChanges();

                MessageBox.Show("Вы сохранили игру");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btGuitar_Click(object sender, RoutedEventArgs e)
        {
            GuitarWindow guitarWindow = new GuitarWindow();
            guitarWindow.ShowDialog();
            Close();
            gridGuitarInfo.DataContext = null;
            gridGuitarInfo.DataContext = Guitar;
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
            gridInfoWork.DataContext = null;
            gridInfoWork.DataContext = Work;
        }

        private void btLearning_Click(object sender, RoutedEventArgs e)
        {
            ToLearn toLearn = new ToLearn();
            toLearn.ShowDialog();
            Close();
            gridInfoGamer.DataContext = null;
            gridInfoGamer.DataContext = Gamer;
        }

        private void btexit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
