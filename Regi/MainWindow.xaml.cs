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

namespace Regi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int num = 0;
        private void ChekTextBox(object sender, RoutedEventArgs e)
        {
            var TSurname = Surname.Text;
            var TName = Name.Text;
            var TPatronymic = Patronymic.Text;
            var TLogin = Login.Text;
            var TPassword = Password.Text;
            
            if (TSurname.Length == 0)
            {
                MessageBox.Show("Фамилия");
                num++;
            }
            else
            {

            }
            if (TName.Length == 0)
            {
                MessageBox.Show("Имя");
                num++;
            }
            else
            {

            }
            if (TPatronymic.Length == 0)
            {
                num++;
                MessageBox.Show("Отчество");
            }
            else
            {

            }
            if (TLogin.Length == 0)
            {
                MessageBox.Show("Логин");
                num++;
            }
            else
            {

            }
            if (TPassword.Length == 0)
            {
                MessageBox.Show("Пароль");
                num++;
            }
            else
            {

            }
            if (num > 0)
            {
                MessageBox.Show("Заполните пустые поля");
                num = 0;
            }
            else
            {
                MessageBox.Show("Успешная регистрация");
            }
        }
    }
}
