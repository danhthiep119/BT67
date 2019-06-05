using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT67
{
    public class Room:IInputDisplay
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Floor { get; set; }
        public int Max { get; set; }
        public string CodeRoom { get; set; }

        public Room()
        {
        }

        public Room(string name, int price, int floor, int max, string codeRoom)
        {
            Name = name;
            Price = price;
            Floor = floor;
            Max = max;
            CodeRoom = codeRoom;
        }

        public void Input()
        {
            Console.WriteLine("Moi ban nhap ten phong:");
            Name = Console.ReadLine();
            Console.WriteLine("Moi ban nhap gia tien:");
            Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so tang:");
            Floor = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so nguoi toi da:");
            Max = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap ma phong:");
            CodeRoom = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("Thong Tin Phong:\tTen:{0}\tGia Tien:{1}\tSo Tang:{2}\tSo Nguoi Toi Da:{3}\tMa Phong:{4}", Name, Price, Floor, Max, CodeRoom);
        }
    }
}
