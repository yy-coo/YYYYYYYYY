using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _YYYYYYYYY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puppy Dennispuppy = new Puppy(1, "Dennis", "Yellow", 0, "米克斯", "5");
            //最後,叫用DennisCar的方法PrintAllAttrib( )印出所有屬性參數.
            Dennispuppy.PrintAllAttrib();

            //===============================================
            //第二個 使用有參數的建構子設一台車MarysCar.
            //經由建構子函式2 來設定所有屬性
            Puppy Maryspuppy = new Puppy(2, "Mary", "Yellow", 0, "黃金獵犬", "9");

            //最後,叫用 MarysCar的方法PrintAllAttrib( )印出所有屬性參數.
            Maryspuppy.PrintAllAttrib();


        }
    }
}
