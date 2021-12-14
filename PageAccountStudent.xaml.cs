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
    /// Логика взаимодействия для PageAccountStudent.xaml
    /// </summary>
    public partial class PageAccountStudent : Page
    {
        LavrentevMO_PC9_TestDemoEkzEntities db;
        string login;
        public PageAccountStudent(string login, string FIO, string groupNumber, string pass, LavrentevMO_PC9_TestDemoEkzEntities db)
        {
            InitializeComponent();
            TextBoxLogin.Text = login;
            TextBoxFIO.Text = FIO;
            TextBoxGroup.Text = groupNumber;
            TextBoxPass.Text = pass;
            this.db = db;
            this.login = login;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (Students s in db.Students)
            {
                ////s.Login = TextBoxLogin.Text;
                //s.FIO_Student = TextBoxFIO.Text;
                //s.GroupNumber = Int32.Parse(TextBoxGroup.Text);
                //db.SaveChanges();

            }

            foreach (Users u in db.Users)
            {
                if (u.Login == login)
                {
                    u.Password = TextBoxPass.Text;
                    db.SaveChanges();
                }

            }
        }
    }
}
