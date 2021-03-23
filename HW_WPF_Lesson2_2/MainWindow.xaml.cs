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

namespace HW_WPF_Lesson2_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Country> countries = new List<Country>();
        public MainWindow()
        {
            InitializeComponent();

            countries.Add(new Country { CountryName = "Belarus", CapitalCity = "Minsk", FlagImage = "C:/Users/User/source/repos/HW_WPF_Lesson2_2/HW_WPF_Lesson2_2/Resources/belarus.png" });
            countries.Add(new Country { CountryName = "Dominican Republic", CapitalCity = "Santo Domingo", FlagImage = "C:/Users/User/source/repos/HW_WPF_Lesson2_2/HW_WPF_Lesson2_2/Resources/cyprus.png" });
            countries.Add(new Country { CountryName = "Cyprus", CapitalCity = "Nicosia", FlagImage = "C:/Users/User/source/repos/HW_WPF_Lesson2_2/HW_WPF_Lesson2_2/Resources/dominican-republic.png" });

            myComboBox.ItemsSource = countries;
            myComboBox.SelectedIndex = 0;
        }
    }
}
