using System;
using System.Windows;

namespace kapustinRPMBD
{
    /// <summary>
    /// Логика взаимодействия для EditRecord.xaml
    /// </summary>
    public partial class EditRecord : Window
    {
        public EditRecord()
        {
            InitializeComponent();
        }
        AeroflotInfoEntities _dataBase = AeroflotInfoEntities.GetContext();

        AirfloatFlightsInfoTable _object;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Получаем запись по номеру рейса
            _object = _dataBase.AirfloatFlightsInfoTables.Find(DataBaseSupClass.flightNumber);
            //Отображаем данные записи
            FlightNumberTB.Text = _object.FlightNumber.ToString();  
            DestinationTB.Text = _object.Destination;
            DepartureTimeTB.Text = _object.DepartureTime.ToString();
            ArrivalTimeTB.Text = _object.ArrivalTime.ToString();
            AvailableSeatsCountTB.Text = _object.AvailableSeatsCount.ToString();
            AircraftTypeTB.Text = _object.AircraftType.ToString();
            CapacityTB.Text = _object.Capacity.ToString();
        }

        private void EditBTN_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "Проверьте корректность ввода следующих данных:\n";
            TimeSpan departureTime = TimeSpan.Zero,
                     arrivalTime = TimeSpan.Zero;
            string[] departureTimeStr,
                     arrivalTimeStr;            

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

            //Избегание отрицательных чисел путём вывода их абсолютного значения
            //_object.FlightNumber = Math.Abs(flightNum);
            _object.Destination = DestinationTB.Text;
            _object.DepartureTime = departureTime;
            _object.ArrivalTime = arrivalTime;
            _object.AvailableSeatsCount = Math.Abs(seatsNum);
            _object.AircraftType = AircraftTypeTB.Text;
            _object.Capacity = Math.Abs(capacity);

            //Добавляем данные в базу данных
            _dataBase.SaveChanges();
            MessageBox.Show("Информация успешно сохранена.", "Добавление прошло успешно!");
            //Сохраняем изменения
            _dataBase.SaveChanges();
            Close();
        }
    }
}
