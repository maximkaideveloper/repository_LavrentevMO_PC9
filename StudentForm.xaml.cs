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

namespace LavrentevMO_PC9_TestDemoEkz_Application
{
    /// <summary>
    /// Логика взаимодействия для StudentForm.xaml
    /// </summary>
    /// 

    public partial class StudentForm : Window
    {

        private string comboBoxValue;
        private string FIO_student;
        private LavrentevMO_PC9_TestDemoEkzEntities db;
        PageAccountStudent pageAcc;
        public StudentForm(PageAccountStudent pageAcc, string FIO_student, LavrentevMO_PC9_TestDemoEkzEntities db)
        {
            InitializeComponent();
            dataFrame.Navigate(pageAcc);
            this.pageAcc = pageAcc;
            this.FIO_student = FIO_student;
            this.db = db;
            comboBoxTables.SelectedIndex = 0;
            comboBoxValue = "Администрирование сетевых операционных систем";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxTables.SelectedValue.ToString() == "System.Windows.Controls.ComboBoxItem: Администрирование сетевых операционных систем")
            {
                comboBoxValue = "Администрирование сетевых операционных систем";
            }
            else if (comboBoxTables.SelectedValue.ToString() == "System.Windows.Controls.ComboBoxItem: Внедрение и поддержка компьютерных систем")
            {
                comboBoxValue = "Внедрение и поддержка компьютерных систем";
            }
            else if (comboBoxTables.SelectedValue.ToString() == "System.Windows.Controls.ComboBoxItem: Инструментальные средства разработки программного обеспечения")
            {
                comboBoxValue = "Инструментальные средства разработки программного обеспечения";
            }
            else if (comboBoxTables.SelectedValue.ToString() == "System.Windows.Controls.ComboBoxItem: Математическое моделирование")
            {
                comboBoxValue = "Математическое моделирование";
            }
            else if (comboBoxTables.SelectedValue.ToString() == "System.Windows.Controls.ComboBoxItem: Организация администрирования компьютерных систем")
            {
                comboBoxValue = "Организация администрирования компьютерных систем";
            }

            dataFrame.Navigate(new PageOneStudentAttestation(FIO_student, db, comboBoxValue));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dataFrame.Navigate(pageAcc);
        }
    }
}
