using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxHP = 100;
            int currentHP = 100 - 20;
            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            Console.WriteLine("===과제 제출 온라인===");
            Console.WriteLine("던전에 입장하기 위한 조건 충족 여부를 확인합니다.");
            Console.WriteLine($"레벨 조건 (30 이상) : {requiredLevel < playerLevel}");
            Console.WriteLine($"열쇠 보유 여부 : {hasKey}");
            Console.WriteLine($"체력 조건 (50%이상) : {currentHP >= (maxHP / 2)}");
            bool final = (requiredLevel < playerLevel) && (hasKey) && (currentHP >= (maxHP / 2));
            Console.WriteLine($"\n최종 입장 여부 : {final}");
            Console.WriteLine("환영합니다. 던전에 입장합니다.");

            Console.WriteLine("\n");
            Console.WriteLine("현재 체력을 확인합니다.");
            Console.WriteLine($"체력 : {currentHP} / {maxHP}");
            Console.WriteLine("\n몬스터에게 25의 데미지를 받았습니다.");
            Console.WriteLine($"체력 : {currentHP -= 25} / {maxHP}");
            Console.WriteLine("\n하급 회복 물약을 사용합니다. (+30)");
            Console.WriteLine($"체력 : {currentHP += 30} / {maxHP}");
            Console.WriteLine("\n상태이상 [중독]에 걸려있습니다. (-5)");
            Console.WriteLine($"체력 : {currentHP -= 5} / {maxHP}");

            Console.WriteLine("\n");
            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;
            int expNow = 0;
            Console.WriteLine($"경험치 상태 : {expNow} / {expForLevelUp} ");
            Console.WriteLine($"\n몬스터를 {monstersKilled}체 처치하셨습니다. (150 EXP x3)");
            Console.WriteLine($"\n경험치 상태 : {expNow + expPerMonster * 3} / {expForLevelUp} ");
            Console.WriteLine($"레벨업까지 {expForLevelUp - (expNow + expPerMonster * 3)} 남았습니다. ");

            Console.WriteLine("\n");
            int totalGold = 1234;
            int partyMembers = 5;
            Console.WriteLine($"처치한 몬스터의 {totalGold}골드를 파티원에게 분배합니다. (인원 {partyMembers}명)");
            Console.WriteLine($"파티원에게 인당 {totalGold / partyMembers}골드 씩 지급됩니다.");
            int leftGold = (totalGold % partyMembers);
            Console.WriteLine($"남은 {leftGold}골드는 자동으로 파티장에게 지급됩니다. ");

            Console.WriteLine("\n");
            int originalPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;
            Console.WriteLine("상점을 오픈합니다.");
            Console.WriteLine("해당 아이템을 검색합니다.");
            Console.WriteLine($"VIP : {isVIP} / 쿠폰 사용 : {hasCoupon}");
            Console.WriteLine($"해당 아이템의 가격은 {originalPrice * 0.8 - 500} 골드 입니다.");
            Console.WriteLine($"구매 하시겠습니까?\n");
            Console.ReadLine();
            Console.WriteLine("\n이용해주셔서 감사합니다.");





        }
    }
}
