using Hotel.DesktopUI.HotelServiceReference;
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

namespace Hotel.DesktopUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListRoom_Loaded(object sender, RoutedEventArgs e)
        {
            var service = new HotelServiceClient();
            Room[] rooms = service.SelectAll();
            ListRoom.ItemsSource = rooms;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int numRecord = ListRoom.SelectedIndex + 1;
            string dateFrom = mwDateFrom.Text;
            string dateTo = mwDateTo.Text;
            if (numRecord == 0)
            {
                MessageBox.Show("Виберіть тип номеру");
            }
            else
            {
                if (dateFrom == "" || dateTo == "")
                {
                    MessageBox.Show("Вкажіть період проживання");
                }
                else
                {
                    txtBlock.Text = "Є вільні номери";
                }
            }
        }

        private void btnReserve_Click(object sender, RoutedEventArgs e)
        {
            int numRecord = ListRoom.SelectedIndex + 1;
            if (numRecord == 0)
            {
                MessageBox.Show("Для бронювання виберіть параметри");
            }
            else
            {
                HotelServiceClient idRecord = new HotelServiceClient();
                int _idRecord = idRecord.GetId(numRecord);
                Room room = new Room();
                room = idRecord.GetRowById(_idRecord);
                ReserveRoom reserveRoom = new ReserveRoom();
                DateTime aaa = Convert.ToDateTime(mwDateFrom.Text);
                DateTime bbb = Convert.ToDateTime(mwDateTo.Text);
                string ccc = Convert.ToString(bbb - aaa);
                int price = room.Price;
                reserveRoom.txtBlockType.Text = room.Name;
                reserveRoom.rrDateFrom.Text = mwDateFrom.Text;
                reserveRoom.rrDateTo.Text = mwDateTo.Text;
                reserveRoom.txtBlockCost.Text = price.ToString() + " грн.";
                reserveRoom.txtBlockInfo.Text = "14:00 " + reserveRoom.rrDateFrom.Text + " - 12:00 " + reserveRoom.rrDateTo.Text;
                reserveRoom.Show();
            }
        }
    }
}
