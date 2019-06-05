using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT67
{
    class Program
    {
        static List<KhachHang> khachHangList = new List<KhachHang>();
        static List<Hotel> hotelList = new List<Hotel>();
        static List<Room> roomList = new List<Room>();
        static List<Book> bookList = new List<Book>();
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                Console.Write("Moi ban nhap :");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nhapThongTinHotel();
                        break;
                    case 2:
                        hienThiThongTinHotel(hotelList,roomList);
                        break;
                    case 3:
                        bookRoom();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }
            }
        }
        static void nhapThongTinHotel()
        {
            Console.Write("Moi ban nhap so khach san can nhap");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Khach San Thu:{0}",(i+1));
                Hotel hotel= new Hotel();
                hotel.Input();
                hotelList.Add(hotel);
                Console.Write("Moi ban nhap so phong khach san:");
                int m = int.Parse(Console.ReadLine());
                for(int j = 0; j < m; j++)
                {
                    Room room = new Room();
                    room.Input();
                    roomList.Add(room);
                }
            }
        }
        static void hienThiThongTinHotel(List<Hotel> hotelList,List<Room> roomList)
        {
            foreach(var obj1 in hotelList)
            {
                foreach(var obj2 in roomList)
                {
                    obj1.Display();
                    obj2.Display();
                }
            }
        }
        static void bookRoom()
        {
            Book book = new Book();
            book.Input();
            bookList.Add(book);
        }
        static void ShowMenu()
        {
            Console.WriteLine("Khach San 4*");
            Console.WriteLine("1. Nhap thong tin khach san");
            Console.WriteLine("2. Hien thi thong tin khach san");
            Console.WriteLine("3. Dat phong nghi");
            Console.WriteLine("4. Tim phong con trong");
            Console.WriteLine("5. Thong ke doanh duy khach san");
            Console.WriteLine("6. Tim kiem thong tin khach hang.");
            Console.WriteLine("7. Thoat chuong trinh");
        }
    }
}
