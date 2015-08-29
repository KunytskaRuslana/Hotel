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
using System.Windows.Shapes;

namespace Hotel.DesktopUI
{
    /// <summary>
    /// Interaction logic for ReserveRoom.xaml
    /// </summary>
    public partial class ReserveRoom : Window
    {
        private string typeRoom;
        private string dateFrom;
        private string dateTo;
        private string fio;
        private string tel;
        private string email;
        private string cost;
        private int IDRecord;

        public string _TypeRoom
        {
            get { return this.typeRoom; }
            set { this.typeRoom = value; }
        }
        public string _DateFrom
        {
            get { return this.dateFrom; }
            set { this.dateFrom = value; }
        }
        public string _DateTo
        {
            get { return this.dateTo; }
            set { this.dateTo = value; }
        }
        public string _Fio
        {
            get { return this.fio; }
            set { this.fio = value; }
        }
        public string _Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }
        public string _Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string _Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }
        public int _IDRecord
        {
            get { return IDRecord; }
            set { IDRecord = value; }
        }

        public ReserveRoom()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            _TypeRoom = txtBlockType.Text;
            _DateFrom = rrDateFrom.Text;
            _DateTo = rrDateTo.Text;
            _Fio = txtFio.Text;
            _Tel = txtTel.Text;
            _Email = txtEmail.Text;
            _Cost = txtBlockCost.Text;
            BrokedRoomDTO brokedRoom = new BrokedRoomDTO();
            brokedRoom.Fio = _Fio;
            brokedRoom.NumberPhone = _Tel;
            brokedRoom.Email = _Email;
            brokedRoom.DescriptionRommId = _IDRecord;            
            brokedRoom.DateFrom = _DateFrom;
            brokedRoom.DateTo = _DateTo;
            brokedRoom.Reserve = 1;
            HotelServiceClient broked = new HotelServiceClient();
            broked.BrokedRoom(brokedRoom);
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
