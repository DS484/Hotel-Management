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
        public AdminDAO() { }

        public DataTable GetHotelRevenue()
        {
            string query = @"with room_revenue as (
	                        select r.id, r.hotel_id,
	                        sum(r.curr_price * DATEDIFF(day, bk.checkin, bk.checkout)) as Revenue
	                        from Rooms r
	                        join Booking bk
		                        on r.id = bk.room_id
	                        group by r.id, r.hotel_id
                        ) 
                        select h.id, h.hotel_name as ""Tên khách sạn"", h.address as ""Địa chỉ"", h.city as ""Thành phố"", 
                        case 
	                        when rr.hotel_id is null then 0
	                        else sum(rr.Revenue)
                        end ""Tổng doanh thu""
                        from hotels h
                        left join room_revenue rr
	                        on h.id = rr.hotel_id
                        group by h.id, h.hotel_name, h.address, h.city, rr.hotel_id
                        order by ""Tổng doanh thu"" desc;";
            object[] parameter = { };
            return db.ExecuteQuery(query, parameter);
        }

        public DataTable TopCustomer()
        {
            string query = "SELECT u.username, u.first_name, u.last_name, u.identify_card, u.gender, u.phone_number, COUNT(*) as Solan FROM Users u JOIN Booking b ON u.id = b.user_id GROUP BY u.first_name, u.username, u.first_name, u.last_name, u.identify_card, u.gender, u.phone_number HAVING COUNT(*) >= 1";

            object[] parameter = {};
            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public DataTable GetFamousLocation()
        {
            string query = @"select h.address as ""Địa chỉ"", h.city as ""Thành phố"", count(*) as ""Số lượng đặt phòng""
                            from hotels h
                            left join rooms r
	                            on h.id = r.hotel_id
                            left join Booking bk
	                            on r.id = bk.room_id
                            where bk.id is not null
                            group by h.address, h.city
                            order by count(*) desc;";
            object[] parameter = { };
            return db.ExecuteQuery(query, parameter);

        }

        public DataTable VIPCustomer()
        {
            string query = "SELECT u.username, u.first_name, u.last_name, u.identify_card, u.gender, u.phone_number FROM Users u JOIN Booking b ON u.id = b.user_id JOIN Rooms r ON r.id = b.room_id WHERE r.curr_price >= '5000000'";

            object[] parameter = { };

            DataTable dt = db.ExecuteQuery(query, parameter);
            return dt;
        }

        public DataTable GetHotHotel()
        {
            string query = @"select h.address as ""Địa chỉ"", h.city as ""Thành phố"", count(*) as ""Số lượng đặt phòng""
                            from hotels h
                            left join rooms r
	                            on h.id = r.hotel_id
                            left join Booking bk
	                            on r.id = bk.room_id
                            where bk.id is not null
                            group by h.address, h.city
                            order by count(*) desc;";
            object[] parameter = { };
            return db.ExecuteQuery(query, parameter);
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
