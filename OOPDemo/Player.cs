using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public class Car
    {
        private string _make;
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        private string _color;

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Car: {Make} Color: {Color}" );
        }

        //public static void PrintCarInfoStatic()
        //{
        //    Console.WriteLine("Det här är en statisk metod.");
        //}
    }
}
