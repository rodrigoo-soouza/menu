using System;

namespace Menu
{
    class Login
    {
              
        static void Main(string[] args)
        {
            Console.Title = "Login";
            MenuPrincipal.Logo();
            Console.WriteLine("Bem Vindo!");
            Console.ReadKey();
            MenuPrincipal.CriarMenu();
        }
    }

    
}