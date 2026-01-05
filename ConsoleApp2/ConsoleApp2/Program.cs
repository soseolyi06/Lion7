using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MASTER_VOLUME               = 100;
            int CHARACTERS_VOLUME           = 100;
            int MUSIC_VOLUME                = 100;
            int SOUND_EFFECTS_VOLUME        = 100;
            int INCOMING_VOICE_CHAT_VOLUME  = 100;
            

            Console.WriteLine("                        OPTIONS               ");
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃   MASTER_VOLUME                ━━━━━┼─────   {MASTER_VOLUME             } %  ┃");
            Console.WriteLine($"┃   CHARACTERS_VOLUME            ━━━━━┼─────   {CHARACTERS_VOLUME         } %  ┃");
            Console.WriteLine($"┃   MUSIC_VOLUME                 ━━━━━┼─────   {MUSIC_VOLUME              } %  ┃");
            Console.WriteLine($"┃   SOUND_EFFECTS_VOLUME         ━━━━━┼─────   {SOUND_EFFECTS_VOLUME      } %  ┃");
            Console.WriteLine($"┃   INCOMING_VOICE_CHAT_VOLUME   ━━━━━┼─────   {INCOMING_VOICE_CHAT_VOLUME} %  ┃");
            Console.WriteLine("┃   VOICE CHAT                        ■              ┃");
            Console.WriteLine("┃   PUSH TO TALK                      ■              ┃");
            Console.WriteLine("┃   DISABLE MASTER EQ                 □              ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


        }
    }
}
