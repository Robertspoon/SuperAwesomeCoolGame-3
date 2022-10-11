using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperAwesomeCoolGame_3
{
    internal class Program
    {
        static int health;
        static int shield;
        static int score;

        static void Main(string[] args)
        {
            Console.WriteLine("<-------------------------------------->");
            Console.WriteLine("THE SUPER AWESOME COOL GAME THE THIRD!!!");
            Console.WriteLine("<-------------------------------------->");
            Console.WriteLine();

            health = 100;
            score = 0;
            shield = 100;

            ShowHUD();

            Console.ReadKey();
        }
        static void ShowHUD()
        {
            Console.WriteLine("<-------------->");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("<-------------->");


        }
        static void TakeDamage(int damage)
        {
            health = health - damage;
            if (health <0)
            {
                health = 0;
            }
        }
        static void Heal(int heal)
        {
            health = health + heal;
            if (health >100)
            {
                health = 100;
            }
        }
    }
}
