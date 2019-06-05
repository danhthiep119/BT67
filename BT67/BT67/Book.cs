using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT67
{
    class Book : IInputDisplay
    {
        public string DateBook { get; set; }
        public string DateEnd { get; set; }
        public int Cmnd { get; set; }
        public string CodeHotel { get; set; }
        public string CodeRoom { get; set; }

        public Book()
        {
        }

        public Book(string dateBook, string dateEnd, int cmnd, string codeHotel, string codeRoom)
        {
            DateBook = dateBook;
            DateEnd = dateEnd;
            Cmnd = cmnd;
            CodeHotel = codeHotel;
            CodeRoom = codeRoom;
        }

        public void CheckCmnd()
        {
            KhachHang kh = new KhachHang();
            Console.WriteLine("Moi ban nhap CMND:");
            Cmnd = int.Parse(Console.ReadLine());
            if (!Cmnd.Equals(kh.Cmnd))
            {
                kh.Input();
            }
        }
        public void CheckHotel()
        {
            Hotel hotel = new Hotel();
            Console.WriteLine("Moi ban nhap ma khach san:");
            CodeHotel = Console.ReadLine();
            if (!CodeHotel.Equals(hotel.CodeHotel))
            {
                hotel.Input();
            }
        }

        public void CheckRoom()
        {
            Room room = new Room();
            Console.WriteLine("moi ban nhap ma phong");
            CodeRoom = Console.ReadLine();
            if(!CodeRoom.Equals(room.CodeRoom))
            {
                CheckRoom();
            }
        }

        public void Input()
        {
            Console.WriteLine("Moi ban nhap ngay dat phong:");
            DateBook = Console.ReadLine();
            Console.WriteLine("Moi ban nhap ngay tra phong");
            DateEnd = Console.ReadLine();
            CheckCmnd();
            CheckHotel();
            CheckRoom();
        } 

        public void Display()
        {
            Console.WriteLine("Thong Tin Book:\tNgay Book:{0}\tNgay Tra:{1}\tCMND:{2}\tMa Khach San{3}\tMa Phong:{4}", DateBook, DateEnd,Cmnd,CodeHotel,CodeRoom);
        }

        
    }
}
