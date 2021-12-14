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

    class GUI
    {
        static public TextBlock createTextBlock(string text)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Text = text;
            return textBlock;
        }
    }

    /// <summary>
    /// Логика взаимодействия для PageOneStudentAttestation.xaml
    /// </summary>
    public partial class PageOneStudentAttestation : Page
    {
        private string subject;
        public PageOneStudentAttestation(string FIO_student, LavrentevMO_PC9_TestDemoEkzEntities db, string subjet)
        {
            InitializeComponent();

            RowDefinition newRow = new RowDefinition();
            //newRow.Height;
            newRow.Height = new GridLength(40);
            dataGrid.RowDefinitions.Add(newRow);


                foreach (AttestationStudent a in db.AttestationStudent)
                {
                    int Sum=0;
                    if (a.Subject_Name == subject)
                    {
                        TextBlock textBlock = GUI.createTextBlock(a.Mark.ToString());
                        dataGrid.Children.Add(textBlock);
                        Grid.SetRow(textBlock, dataGrid.Children.Count-1);

                        if(a.Attestation_Number == 1) {
                            Grid.SetColumn(textBlock, 2);
                        }
                        else if (a.Attestation_Number == 2)
                        {
                            Grid.SetColumn(textBlock, 3);
                        }
                        else if (a.Attestation_Number == 3)
                        {
                            Grid.SetColumn(textBlock, 4);
                        }
                        Sum += a.Mark;
                    }

                    TextBlock textBlockSum = GUI.createTextBlock(Sum.ToString());
                    dataGrid.Children.Add(textBlockSum);
                    Grid.SetRow(textBlockSum, dataGrid.Children.Count - 1);
                    Grid.SetColumn(textBlockSum, 5);
                }         
        }


    }
}
