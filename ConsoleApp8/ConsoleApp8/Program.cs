using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"=== 캐릭터 생성 ===");
            Console.WriteLine($"캐릭터 이름을 입력하세요 : \n");
            string UserName = Console.ReadLine();
            Console.WriteLine($"환영합니다. {UserName}님");

            Console.WriteLine($"시작 레벨을 입력하세요 : ");
            string Level = Console.ReadLine();
            int StrarLevel = int.Parse(Level);
            Console.WriteLine($"{UserName}님의 시작 레벨은 {Level}입니다.");
        }
    }
}
