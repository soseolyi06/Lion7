using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"당신의 직업을 추천드릴게요!");
            Console.WriteLine($"당신의 성향 수치를 입력해주세요. (1~100)");
            string input = Console.ReadLine();
            int trait = int.Parse(input);
            int jabCode = 0;

            if (trait >= 80)
            {
                Console.WriteLine("\n당신의 마음은 뜨겁군요!!");
                jabCode = 1;
            }
            else if (trait >= 60)
            {
                Console.WriteLine("\n당신의 마음은 따뜻하군요~!");
                jabCode = 2;
            }
            else if (trait >= 40)
            {
                Console.WriteLine("\n당신의 마음은 상냥하군요~ ");
                jabCode = 3;
            }
            else if (trait >= 20)
            {
                Console.WriteLine("\n당신의 마음은 옳곧군요");
                jabCode = 4;
            }
            else if (trait >= 0)
            {
                Console.WriteLine("\n당신의 마음은 냉철하군요.");
                jabCode = 5;
            }
            else
            {
                Console.WriteLine("\n당신의 마음은 정녕 사람인가요?!");
                jabCode = 6;
            }
            Console.WriteLine("\n당신의 직업은!?");
            switch (jabCode)
            {
                case 1:
                    Console.WriteLine("우직한 전사! 축하해요~");
                    break;
                case 2:
                    Console.WriteLine("용맹한 검사! 축하해요~");
                    break;
                case 3:
                    Console.WriteLine("상냥한 치유사! 축하해요~");
                    break;
                case 4:
                    Console.WriteLine("날렵한 도적! 축하해요~");
                    break;
                case 5:
                    Console.WriteLine("화려한 마법사! 축하해요~");
                    break;
                case 6:
                    Console.WriteLine("경고. 규격 외 마왕! 축하해요~");
                    break;
            }
        }
    }
}
