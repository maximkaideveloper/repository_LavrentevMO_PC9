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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LavrentevMO_PC9_TestDemoEkz_Application
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isInput;
        LavrentevMO_PC9_TestDemoEkzEntities database;
        public MainWindow()
        {
            InitializeComponent();
            database = new LavrentevMO_PC9_TestDemoEkzEntities();
            isInput = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (Users u in database.Users)
            {
                if (u.Login == TextBoxLogin.Text && u.Password == TextBoxPassword.Text) 
                {

                    string login = u.Login;
                    string pass = u.Password;

                    if (u.Role == "Студент")
                    {
                        foreach (Students s in database.Students)
                        {
                            if (s.Login == login)
                            {
                                isInput = true;

                                if (TextBoxLogin.Text == "" || TextBoxPassword.Text == "")
                                {
                                    MessageBox.Show("Одно из полей ввода пусто");
                                }
                                else
                                {
                                    try
                                    {
                                        PageAccountStudent pageAcc = new PageAccountStudent(login, s.FIO_Student, s.GroupNumber.ToString(), pass, database);
                                        StudentForm studentForm = new StudentForm(pageAcc, s.FIO_Student, database);
                                        studentForm.Show();
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Возникла ошибка ввода данных. Попробуйте ввести данные ещё раз");
                                    }
                                }
                            }
                        }
                    }

                    if (!isInput)
                    {
                        MessageBox.Show("Возникла ошибка ввода данных. Попробуйте ввести данные ещё раз");
                    }

                    else if (u.Role == "Преподаватель")
                    {

                    }
                    else if (u.Role == "Администратор")
                    {

                    }
                }
            }
        }
    }
}
