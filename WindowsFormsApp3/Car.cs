using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
   public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static int id = 100;
        public Car()
        {
            Id = ++id;
        }
        public override string ToString()
        {
            return $"ID : {Id}  Car : {Name}";
        }
    }
}
