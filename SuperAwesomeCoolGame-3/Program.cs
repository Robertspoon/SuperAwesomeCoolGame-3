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
        static int lives;

        static void Main(string[] args)
        {
            Console.WriteLine("<-------------------------------------->");
            Console.WriteLine("THE SUPER AWESOME COOL GAME THE THIRD!!!");
            Console.WriteLine("<-------------------------------------->");
            Console.WriteLine();

            health = 100;
            score = 0;
            shield = 100;
            lives = 3;

            ShowHUD();
            Console.WriteLine();

            Console.WriteLine("You encounter an enemy goblin!");
            Console.ReadKey(true);
            Console.WriteLine("The goblin strikes you with their axe!");
            takeShieldDamage(50);
            Console.ReadKey();
            ShowHUD();
            Console.WriteLine("You shoot the goblin, but he's still standing!");
            Console.ReadKey(true);
            Console.WriteLine("The goblin strikes you again, breaking your shield!");
            takeShieldDamage(50);
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);
            Console.WriteLine("You shoot the goblin again, killing him!");
            EnemyValue(100);
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);
            Console.WriteLine("You discovered a shield restoration unit, healng 50% of your shield!");
            RestoreShield(50);
            Console.WriteLine();
            Console.ReadKey(true);
            ShowHUD();
            Console.WriteLine();
            Console.WriteLine("You encounter a stone golem!");
            Console.WriteLine("The stone golem strikes you, breaking your shield!");
            Console.ReadKey(true);
            takeShieldDamage(50);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);
            Console.WriteLine("You try shooting the stone giants but bullets have no affect on him!");
            Console.WriteLine("The Golem strikes you, dealing 40 damage!");
            Console.ReadKey(true);
            TakeDamage(40);
            Console.WriteLine();
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);
            Console.WriteLine("You switch to your Partical Disintegrator so you can destroy the golem that stands before you");
            Console.ReadKey(true);
            ShowHUD();
            Console.WriteLine();
            Console.ReadKey(true);
            Console.WriteLine("You blast the golem with your P.D., destroying it instantly!");
            Console.WriteLine();
            Console.ReadKey(true);
            EnemyValue(300);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("Oh goody would you look at that, the golem dropped a health restoration kit, healing you for 20 HP!");
            Console.ReadKey(true);
            Console.WriteLine();
            Heal(20);
            ShowHUD();

            Console.ReadKey();
        }
        static void ShowHUD()
        {
            string status;
            status = "FINE AND DANDY";



            Console.WriteLine("<-------------->");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);
            //Console.WriteLine("Current Weapon: " +);
            if ((health >= 50) && (health <= 75))
            {
                status = "JUST A FLESH WOUND";
            }

            if ((health >= 25) && (health <= 50))
            {
                status = "NOT LOOKING GOOD";
            }

            if ((health >= 0) && (health <= 25))
            {
                status = "ON YOUR LAST LEG";
            }
            Console.WriteLine("Health Status: " + status);


            Console.WriteLine("<-------------->");

        }
        static void takeShieldDamage(int shieldDamage)
        {
            shield = shield - shieldDamage;
            if (shield < 0)
            {
                shield = 0;
            }
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
        static void RestoreShield(int healShield)
        {
            shield = shield + healShield;
            if (shield > 100)
            {
                shield = 100;
            }
        }

        static void ChangeWeapon(int weapon)
        {

        }

        static void EnemyValue(int enemyValue)
        {
            score = score + enemyValue;
        }
        static void LoseLife(int loseLives)
        {
            lives = lives - loseLives;
        }
    }
}
