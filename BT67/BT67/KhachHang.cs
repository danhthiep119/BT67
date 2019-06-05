using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT67
{
    public class KhachHang:IInputDisplay
    {
        public int Cmnd { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string CountrySide { get; set; }

        public KhachHang()
        {

        }

        public KhachHang(int cmnd,string name,int age,string gender,string countryside) {
            Cmnd = cmnd;
            Name = name;
            Age = age;
            Gender = gender;
            CountrySide = countryside;
        }

        public void Input()
        {
            Console.WriteLine("Moi ban nhap CMND:");
            Cmnd = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap ten:");
            Name = Console.ReadLine();
            Console.WriteLine("Moi ban nhap tuoi:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap gioi tinh:");
            Gender= Console.ReadLine();
            Console.WriteLine("Moi ban nhap que quan:");
            CountrySide= Console.ReadLine(); 
        }

        public void Display()
        {
            Console.WriteLine("Thong Tin:\tCMND:{0}\tTen:{1}\tTuoi:{2}\tGioi Tinh:{3}\tQueQuan:{4}", Cmnd, Name, Age, Gender, CountrySide);
        }
    }
}
