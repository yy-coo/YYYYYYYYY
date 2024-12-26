using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _YYYYYYYYY
{
    internal class Puppy
    {
        // 屬性
        public int Id { get; set; }
        public string Owner { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Variety { get; set; }
        public string Age { get; set; }


        // 方法：呼叫 Puppy 名稱
        public string CallMyPuppyName()
        {
            return $"Id: {Id}, Owner: {Owner}, Color: {Color}, Price: {Price}, Variety: {Variety}, Age: {Age}";
        }

        // 建構子函式1
        public Puppy() { }

        // 建構子函式2
        public Puppy(int id, string vOwner, string color, double price, string variety, string age)
        {
            Id = id;
            Owner = vOwner;
            Color = color;
            Price = price;
            Variety = variety;
            Age = age;
        }

        // 方法：列印所有屬性
        public void PrintAllAttrib()
        {
            Console.WriteLine(CallMyPuppyName());
        }
    }
}
