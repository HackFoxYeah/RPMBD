using System;
using System.Windows;

namespace kapustinRPMBD
{
    /// <summary>
    /// Логика взаимодействия для AddRecord.xaml
    /// </summary>
    public partial class AddRecord : Window
    {
        public AddRecord()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Доступ к контексту данных.
        /// </summary>
        AeroflotInfoEntities _dataBase = AeroflotInfoEntities.GetContext();
        /// <summary>
        /// Элемент таблицы.
        /// </summary>
        AirfloatFlightsInfoTable _object = new AirfloatFlightsInfoTable();
        private void AddRecordBTN_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "Проверьте корректность ввода следующих данных:\n";
            TimeSpan departureTime = TimeSpan.Zero,
                     arrivalTime = TimeSpan.Zero;
            string[] departureTimeStr,
                     arrivalTimeStr;

            if (!int.TryParse(FlightNumTB.Text, out int flightNum))
                errorMessage += "+ Номер рейса\n";

            if (string.IsNullOrEmpty(DestinationTB.Text))
                errorMessage += "+ Пункт назначения\n";

            try
            {
                departureTimeStr = DepartureTimeTB.Text.Split(new char[] { ':', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                departureTime = new TimeSpan(int.Parse(departureTimeStr[0]), int.Parse(departureTimeStr[1]), 0);
            }
            catch (Exception)
            {
                errorMessage += "+ Время вылета\n";
            }

            try
            {
                arrivalTimeStr = ArrivalTimeTB.Text.Split(new char[] { ':', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                arrivalTime = new TimeSpan(int.Parse(arrivalTimeStr[0]), int.Parse(arrivalTimeStr[1]), 0);
            }
            catch (Exception)
            {
                errorMessage += "+ Время прибытия\n";
            }

            if (!int.TryParse(AvailableSeatsCountTB.Text, out int seatsNum))
                errorMessage += "+ Кол-во свободных мест\n";

            if (string.IsNullOrEmpty(AircraftTypeTB.Text))
                errorMessage += "+ Тип самолёта\n";

            if (!int.TryParse(CapacityTB.Text, out int capacity))
                errorMessage += "+ Вместимость\n";

            if (errorMessage.Split(' ').Length != 5)
            {
                MessageBox.Show(errorMessage, "Обнаружены ошибки!");
                Close();
                return;
            }

            _object.FlightNumber = Math.Abs(flightNum);
            _object.Destination = DestinationTB.Text;
            _object.DepartureTime = departureTime;
            _object.ArrivalTime = arrivalTime;
            _object.AvailableSeatsCount = Math.Abs(seatsNum);
            _object.AircraftType = AircraftTypeTB.Text;
            _object.Capacity = Math.Abs(capacity);

            //Добавляем данные в базу данных
            _dataBase.AirfloatFlightsInfoTables.Add(_object);
            MessageBox.Show("Информация успешно сохранена.", "Добавление прошло успешно!");
            //Сохраняем изменения
            _dataBase.SaveChanges();
            Close();
        }

        private void CancelTB_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
