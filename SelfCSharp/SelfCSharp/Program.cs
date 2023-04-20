using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("あなたは寿司が好きですか？(はいorいいえ）");
            string ans = Console.ReadLine();
            if (ans == "はい") 
                Console.WriteLine("おお！美味しいですよね！");
            else if (ans == "いいえ") 
            Console.WriteLine("それは悲しいです、、、");
            
        }
    }
}
