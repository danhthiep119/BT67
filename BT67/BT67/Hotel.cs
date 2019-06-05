using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT67
{
    public class Hotel:IInputDisplay
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string ListRoom { get; set; }
        public string CodeHotel { get; set; }

        public Hotel()
        {
        }

        public Hotel(string name, string address, string type, string listRoom, string codeHotel)
        {
            Name = name;
            Address = address;
            Type = type;
            ListRoom = listRoom;
            CodeHotel = codeHotel;
        }

        public void Input()
        {
            Console.WriteLine("Moi ban nhap ten khach san:");
            Name = Console.ReadLine();
            Console.WriteLine("Moi ban nhap dia chi:");
            Address = Console.ReadLine();
            Console.WriteLine("Moi ban nhap loai khach san:");
            Type = Console.ReadLine();
            Console.WriteLine("Moi ban nhap danh sach phong:");
            ListRoom = Console.ReadLine();
            Console.WriteLine("Moi ban nhap ma khach san:");
            CodeHotel = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Thong Tin Khach San:\tTen:{0}\tDia Chi:{1}\tLoai:{2}\tDanh Sach Phong:{3}\tMa Khach San:{4}",Name,Address,Type,ListRoom,CodeHotel);
        }
    }
}
