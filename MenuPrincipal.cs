using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;

namespace Menu
{
    class MenuPrincipal
    {

        public static void CriarMenu()
        {
            for (; ; )
            {

                Console.Clear();
                Logo();
                Diga("1", "Verificar");
                Diga("2", "Info");
                Diga("3", "Discord server");
                Diga("4", "Sair");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    //Vá para 1
                }
                else if (option == "2")
                {
                    //Vá para 2
                }
                else if (option == "3")
                {
                    //Vá para 3
                }
                else if (option == "4")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Erro. Digite novamente");
                    Thread.Sleep(1500);
                }
            }
        }

        public static void Diga(string prefixo, string mensagem)
        {
            Console.Write("[");
            Console.Write(prefixo, Color.BlueViolet);
            Console.WriteLine("] " + mensagem);
        }

        public static void Logo()
        {
            string logo = @"  _   _                      
 | \ | | ___  _ __ ___   ___ 
 |  \| |/ _ \| '_ ` _ \ / _ \
 | |\  | (_) | | | | | |  __/
 |_| \_|\___/|_| |_| |_|\___|
";
            Console.WriteLine(logo, Color.BlueViolet);
        }
    }
 
}
