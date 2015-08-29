using Hotel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositories
{
    public interface IRoomRepository
    {
        List<Room> SelectAll();
        NewRoom AddRecord(NewRoom newRoom);
        int GetId(int numRecord);
        Room GetRowById(int id);
        void BrokedRoom(NewRoom newRoom);
    }
}
