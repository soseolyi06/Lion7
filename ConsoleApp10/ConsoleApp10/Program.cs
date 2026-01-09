using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.SetWindowSize(100, 25);   // 콘솔 창 크기 설정 (가로 80, 세로 25)
            Console.SetBufferSize(100, 25);   // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            ConsoleKeyInfo Start;
            Random rand = new Random();

            int pmoney = 950;
            int stone = 0;
            int power = 1;
            int input = 0;
            int rnd;
            int chois = 1;
            //칭호
            int title1 = 0;
            int title2 = 0;
            int title3 = 0;
            int title4 = 0;
            int title5 = 0;

            Thread.Sleep(500);


            //무한반복
            돌아가기:
            while (true)
            {
                Console.Clear(); //화면지우기
                Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.WriteLine("┃             스톤 어택             ┃");
                Console.WriteLine("┃                                   ┃");

                if (chois == 1)
                {
                    Console.WriteLine("┃          ● 바위 캐기             ┃");
                }
                else
                {
                    Console.WriteLine("┃          ○ 바위 캐기             ┃");
                }
                if (chois == 2)
                {
                    Console.WriteLine("┃          ● 장비 뽑기             ┃");
                }
                else
                {
                    Console.WriteLine("┃          ○ 장비 뽑기             ┃");
                }
                if (chois == 3)
                {
                    Console.WriteLine("┃          ●  나가기               ┃ ");
                }
                else
                {
                    Console.WriteLine("┃          ○  나가기               ┃ ");
                }
                Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                Start = Console.ReadKey(true);
                switch (Start.Key)
                {
                    case ConsoleKey.UpArrow: chois--; break;
                    case ConsoleKey.DownArrow: chois++; break;
                    case ConsoleKey.Enter: input = chois; break; continue;
                }
                if (chois == 4)
                {
                    chois = 1;
                }
                if (chois == 0)
                {
                    chois = 3;
                }

                if (input == 1)
                {
                    Console.Clear();
                    bool mining = true; //while on/off 
                    input = 0;
                    ConsoleKeyInfo mine;
                    Console.CursorVisible = false;
                    int x = 3, y = 6;
                    //인게임 돌.
                    int rockX = 70, rockY = 2;
                    int rockW = 5, rockH = 5;

                    while (mining)
                    {
                    Console.Clear();

                        Console.SetCursorPosition(0, 0);
                        Console.Write($"[돌 : {stone}개]   [돈 : {pmoney}원]   [곡괭력 : {power}]");
                        for (int ry = 0; ry < rockH; ry++) //여기 2차원 for문 썼어요~!!!-----------------------
                        {
                            for (int rx = 0; rx < rockW; rx++)
                            {
                                Console.SetCursorPosition(rockX + rx, rockY + ry);
                                Console.Write("▩");
                            }
                        }
                        Console.WriteLine("\n■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                        Console.WriteLine("#바위 앞으로 가 [스페이스 바]를 눌러 채굴하기.");
                        Console.WriteLine("#[E,R,T]를 눌러 돌을 판매해보세요! (백/천/만 개 단위)");
                        Console.WriteLine("#뽑기를 통해 곡괭력을 올려보세요!(1000원 = 5회)\n");
                        if (stone >= 1000000 && title1 == 0) title1 = 1;
                        if (pmoney >= 100000 && title2 == 0) title2 = 1;
                        if (title1 == 1)//칭호1
                        {
                            Console.WriteLine("칭호1: 나는 맹구야 (돌 100만개 획득하기)");
                        }
                        if (title2 >= 1) //칭호2
                        {
                            Console.WriteLine("칭호2: 리치 (돈 10만원 획득하기)");
                        }
                        if (title3 >= 1) //칭호3
                        {
                            Console.WriteLine("칭호3: [스톤 어택]계 페이커! (젠장 숭배해야만 하는 곡괭이 [SSS] (2%) 획득하기");
                        }
                        if (title4 >= 1) //칭호4
                        {
                            Console.WriteLine("칭호4: 당신의 미래가 기대되는군요 (천마신교 성물 제 367호 [SSS] (2%) 획득하기");
                        }
                        if (title5 >= 1) //칭호5
                        {
                            Console.WriteLine("칭호5: 최고의 똥손! (세계제일의 구리구리한 쓰레기 곡괭이 [FFF] (1%) 획득하기");
                        }
                        Console.SetCursorPosition(x, y); //여기 좌표 썼어요~!!!------------------------------
                        bool inFrontOfRock =
                        (x == rockX - 2) &&
                        (y >= rockY && y < rockY + rockH);

                        Console.Write("●"); //캐릭터 겸 유저 겸 플레이어

                        mine = Console.ReadKey(true);

                        switch (mine.Key)//여기 조작 썼어요~!!!----------------------------------------------
                        {
                            case ConsoleKey.LeftArrow: if (x > 0) x--; break;
                            case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++;
                                if (x > 68) x--; break;
                            case ConsoleKey.E:
                                if (stone >= 100)
                                {
                                    stone -= 100;
                                    pmoney += 10;
                                }
                                break;
                            case ConsoleKey.R:
                                if (stone >= 1000)
                                {
                                    stone -= 1000;
                                    pmoney += 100;
                                }
                                break;
                            case ConsoleKey.T:
                                if (stone >= 10000)
                                {
                                    stone -= 10000;
                                    pmoney += 1000;
                                }
                                break;
                            case ConsoleKey.Spacebar: if (inFrontOfRock)
                                {
                                    if (y > 0)
                                    {
                                        Console.SetCursorPosition(x, y - 1);
                                        Console.Write("깡");
                                        Thread.Sleep(20);

                                        // 지우기(같은 자리 공백으로 덮기)
                                        Console.SetCursorPosition(x, y - 1);
                                        Console.Write("  ");
                                    }

                                    stone += (power);    //곡괭력
                                }
                                break;
                            case ConsoleKey.Escape: mining = false; break; //나가기
                        }
                    }
                }
                else if (input == 2)
                {
                반복뽑기:
                    Console.Clear();
                    input = 0;
                    if (pmoney >= 1000)
                    {
                        pmoney -= 1000;

                        //20번 뽑기
                        for (int i = 1; i <= 5; i++)
                        {
                            rnd = rand.Next(1, 201);
                            Console.WriteLine("========================================================");

                            if (rnd >= 1 && rnd <= 2) // 여기 if문!
                            {
                                Console.WriteLine("젠장 숭배해야만 하는 곡괭이 [SSS]");
                                Console.WriteLine("곡괭력 + 222");
                                Console.WriteLine("쉿, 불 좀 꺼줄래? 내 곡괭이 좀 보게");
                                power += 222;
                                title3 += 1;
                            }
                            else if (rnd >= 3 && rnd <= 4)
                            {
                                Console.WriteLine("천마신교 성물 제 367호 [SSS]");
                                Console.WriteLine("곡괭력 + 250");
                                Console.WriteLine("이걸 손에 얻은 자는 모든 종류의 천마신공을 빠르게 습득할 수 있다고 전해진다");
                                power += 250;
                                title4 += 1;
                            }
                            else if (rnd >= 5 && rnd <= 9)
                            {
                                Console.WriteLine("엑스곡괭버 [SS]");
                                Console.WriteLine("곡괭력 + 70");
                                Console.WriteLine("이름을 크게 외치며 휘두르면 잘 캐질것 같다.");
                                power += 70;
                            }
                            else if (rnd >= 10 && rnd <= 14)
                            {
                                Console.WriteLine("C# 곡괭이 [SS]");
                                Console.WriteLine("곡괭력 + 60");
                                Console.WriteLine("딸깍 한번으로 돌을 캘 수 있을 것 같다, 원래 그랬지 않냐고? 조용.");
                                power += 60;
                            }
                            else if (rnd >= 15 && rnd <= 26)
                            {
                                Console.WriteLine("지옥참마곡 [S]");
                                Console.WriteLine("곡괭력 + 18");
                                Console.WriteLine("미안하오 영감, 다신 광질하지 않겠다 했건만...");
                                power += 18;
                            }
                            else if (rnd >= 27 && rnd <= 38)
                            {
                                Console.WriteLine("천사와 악마의 곡괭이 [S]");
                                Console.WriteLine("곡괭력 + 12");
                                Console.WriteLine("악마: 오늘은 공부 때려치우고 놀자 / 천사: 안돼! 열심히 해서 우리 다같이 회식할꺼야");
                                power += 12;
                            }
                            else if (rnd >= 39 && rnd <= 63)
                            {
                                Console.WriteLine("새로 산 신상 곡괭이 [A]");
                                Console.WriteLine("곡괭력 + 7");
                                Console.WriteLine("난 한번 휘두를때마다 버리고 새 곡괭이를 써");
                                power += 7;
                            }
                            else if (rnd >= 64 && rnd <= 88)
                            {
                                Console.WriteLine("마X크X래X 곡괭이 [A]");
                                Console.WriteLine("곡괭력 + 5");
                                Console.WriteLine("뭔가 화질이 구려, 16비트 도트로 찍은것 같은 곡괭이야");
                                power += 5;
                            }
                            else if (rnd >= 89 && rnd <= 143)
                            {
                                Console.WriteLine("깔끔한 곡괭이 [B]");
                                Console.WriteLine("곡괭력 + 1");
                                Console.WriteLine("모든 곡괭이의 원형이 되는 기본적인 곡괭이");
                                power += 1;
                            }
                            else if (rnd >= 144 && rnd <= 198)
                            {
                                Console.WriteLine("양산형 곡괭이 [B]");
                                Console.WriteLine("곡괭력 + 2");
                                Console.WriteLine("양산형은 뻔하지만 그만큼 확실한 재미를 가져다주지");
                                power += 2;
                            }
                            else
                            {
                                Console.WriteLine("세계제일의 구리구리한 쓰레기 곡괭이 [FFF]");
                                Console.WriteLine("곡괭력 -100");
                                Console.WriteLine("앗! 손에 가시가 박히고 쇠독이..!");
                                power -= 100;
                                title5 += 1;
                                if (power <= 0)
                                {
                                    power = 1;
                                }
                            }
                            Thread.Sleep(200); //0.5초정도로 뽑혀라.


                        }
                        Console.WriteLine("\nㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                        Console.WriteLine($"현재 돈 : {pmoney}");
                        Console.WriteLine("뽑기를 다시 하시겠습니까? (Y/N)");
                        int key = Console.Read();
                        Console.ReadLine();
                        if (key == 'Y' || key == 'y')
                        {
                            goto 반복뽑기; //여기 goto 썼어요~!!! --------------------------------------
                        }
                        else if (key == 'N' || key == 'n')
                        {
                            goto 돌아가기;
                        }

                    }
                    else
                    {
                        Console.WriteLine("다시 돌 캐러 가자~ \n");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("게임을 나갑니다.");
                    Environment.Exit(0);
                }

            }
        }
    }
}