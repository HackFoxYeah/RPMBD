using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace kapustinRPMBD
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
        AeroflotInfoEntities _dataBase = AeroflotInfoEntities.GetContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Загружаем таблицу из базы данных.
            _dataBase.AirfloatFlightsInfoTables.Load();
            //Загружаем таблицу в DataGrid с отслеживанием контекста.
            DataGrid.ItemsSource = _dataBase.AirfloatFlightsInfoTables.Local.ToBindingList();
        }
        private void CreateRec_Click(object sender, RoutedEventArgs e)
        {
            AddRecord ar = new AddRecord();
            ar.ShowDialog();
            DataGrid.Focus();
        }

        private void EditRec_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = DataGrid.SelectedIndex;
            if (indexRow != -1)
            {
                AirfloatFlightsInfoTable row = (AirfloatFlightsInfoTable)DataGrid.Items[indexRow];
                DataBaseSupClass.flightNumber = row.FlightNumber;
                DataBaseSupClass.destination = row.Destination;
                DataBaseSupClass.departureTime = row.DepartureTime;
                DataBaseSupClass.arrivalTime = row.ArrivalTime;
                DataBaseSupClass.availableSeatsCount = row.AvailableSeatsCount;
                DataBaseSupClass.aircraftType = row.AircraftType;
                DataBaseSupClass.capacity = row.Capacity;

                EditRecord erForm = new EditRecord();
                erForm.ShowDialog();
                DataGrid.Items.Refresh();
                DataGrid.Focus();
            }
        }

        private void RemoveRec_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;

            result = MessageBox.Show("Удалить запись?", "Удаление записи", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    AirfloatFlightsInfoTable row = (AirfloatFlightsInfoTable)DataGrid.SelectedItems[0];
                    _dataBase.AirfloatFlightsInfoTables.Remove(row);
                    _dataBase.SaveChanges();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Выберите запись");
                }
            }
        }

        private void FindRec_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < DataGrid.Items.Count; i++)
                {
                    var row = (AirfloatFlightsInfoTable)DataGrid.Items[i];
                    string findContent = row.FlightNumber.ToString();

                    if (findContent != null && findContent.Contains(TB.Text))
                    {
                        var item = DataGrid.Items[i];
                        DataGrid.SelectedItem = item;
                        DataGrid.ScrollIntoView(item);
                        DataGrid.Focus();
                        break;
                    }
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Запись с заданным номером рейса не найдена.", "Запись не найдена!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        List<AirfloatFlightsInfoTable> _airfloatFlightsInfoTable;
        private void FilterRec_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(FilterTB.Text, out int filter))
            {
                _airfloatFlightsInfoTable = _dataBase.AirfloatFlightsInfoTables.ToList();
                var filtered = _airfloatFlightsInfoTable.Where(x => x.FlightNumber == filter);
                DataGrid.ItemsSource = filtered;
            }
            else
                MessageBox.Show("Введите корректный запрос на фильтрацию", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
