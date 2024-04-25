using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.DAO
{
    internal class AdminDAO
    {
        private DBConnection db = new DBConnection();
        public DataTable TopCustomer()
        {
            string query = "SELECT u.username, u.first_name, u.last_name, u.identify_card, u.gender, u.phone_number, COUNT(*) as Solan FROM Users u JOIN Booking b ON u.id = b.user_id GROUP BY u.first_name, u.username, u.first_name, u.last_name, u.identify_card, u.gender, u.phone_number HAVING COUNT(*) >= 1";

            object[] parameter = {};

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public DataTable VIPCustomer()
        {
            string query = "SELECT u.username, u.first_name, u.last_name, u.identify_card, u.gender, u.phone_number FROM Users u JOIN Booking b ON u.id = b.user_id JOIN Rooms r ON r.id = b.room_id WHERE r.curr_price >= '5000000'";

            object[] parameter = { };

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public DataTable HotelRevenue()
        {
            string query = "select h.id, h.hotel_name, h.address, h.city, count(*) as Soluongdanhgia from hotels h left join Feedback f on h.id = f.hotel_id where f.id is not null group by h.id, h.hotel_name, h.address, h.city order by count(*) desc";

            object[] parameter = { };

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }
    }
}
