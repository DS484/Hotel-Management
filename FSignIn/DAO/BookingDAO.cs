using Hotel_Management.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAO
{
    public class BookingDAO
    {
        DBConnection db = new DBConnection();

        public bool CreateBooking(DateTime checkInDate, DateTime checkOutDate,
            int roomId, int userId, int voucher)
        {
            string query = $"INSERT INTO Booking(checkin, checkout, room_id, user_id, has_voucher) VALUES ('{checkInDate}', '{checkOutDate}', '{roomId}', '{userId}', {voucher})";
            int inserted = db.ExecuteNoneQuery(query);
            if (inserted > 0) return true;
            return false;
        }

        public DataTable CheckBooking(int roomId)
        {
            string query = "SELECT * FROM Booking WHERE room_id = @roomId ORDER BY checkin";

            object[] parameter = { roomId };

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }
    }
}
