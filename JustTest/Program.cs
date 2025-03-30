using System;

namespace JustTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Gun gun = new Gun();
            player.Shoot(gun);
            player.Shoot(gun);
        }
    }

    abstract class Weapon
    {
        public abstract void Fire();
    }

    class Gun : Weapon
    {
        public override void Fire()
        {
            Console.WriteLine("Бах");
        }
    }

    class Player
    {
        public void Shoot(Weapon weapon)
        {
            weapon.Fire();
        }
    }
}
