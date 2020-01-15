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

namespace WpfApp13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TESTEntities db = new TESTEntities();
        public MainWindow()
        {
                      

            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (db.users.Where(u => u.password == t1.Text && u.login == t2.Text).FirstOrDefault() != null)
            {
                Window1 window = new Window1();
                window.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }


        }
    }
}
