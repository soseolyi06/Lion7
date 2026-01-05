using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte level = 50;          // 레벨 (0~255면 충분)
            short attack = 1500;      // 공격력
            int gold = 1234567;       // 소지금
            long experience = 99999999L; // 경험치 (큰 값, L 접미사)

            Console.WriteLine("=== 캐릭터 정보 ===");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"소지금: {gold:N0}골드");
            Console.WriteLine($"경험치: {experience:N0}");

            Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            Console.WriteLine($"short 최대값: {short.MaxValue}");
            Console.WriteLine($"int 최대값: {int.MaxValue:N0}");
            Console.WriteLine($"long 최대값: {long.MaxValue:N0}");
        }
    }
}
