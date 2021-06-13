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
using System.Text.RegularExpressions;

namespace zad1
{
    /// <summary>
    /// Logika interakcji dla klasy StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public Student student;
        public StudentWindow(Student student = null)
        {
            if (student != null)
            {
                InitializeComponent();
                TbIm.Text = student.imie;
                TbNaz.Text = student.nazwisko;
                TbNr.Text = student.NrIndeksu.ToString();
                TbWyd.Text = student.wydzial;
            }
            this.student = student ?? new Student();
        }
        public StudentWindow()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(TbIm.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
                !Regex.IsMatch(TbNaz.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
                !Regex.IsMatch(TbWyd.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
                !Regex.IsMatch(TbNr.Text, @"^[0-9]{4,10}$"))
            {
    
                MessageBox.Show("Podane błedne dane.");
                return;
            }

            student = new Student();
            student.imie = TbIm.Text;
            student.nazwisko = TbNaz.Text;
            student.NrIndeksu = int.Parse(TbNr.Text);
            student.wydzial = TbWyd.Text;

            this.DialogResult = true;
        }
    }
}//z jakiegos powodu 
