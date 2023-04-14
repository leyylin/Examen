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

namespace Examen
{
    /// <summary>
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit : Page
    {
        private Заказы _currentOrder = new Заказы();
        public AddEdit(Заказы SelectOrder)
        {
            InitializeComponent();
            if (SelectOrder != null)
            {
                _currentOrder = SelectOrder;
            }
            DataContext = _currentOrder;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrEmpty(_currentOrder.Статус_заказа))

                errors.AppendLine("Укажите статус");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentOrder.Номер_заказа == 0)
                ExamenEntities.GetContext().Заказы.Add(_currentOrder);

            try
            {
                ExamenEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                this.NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
