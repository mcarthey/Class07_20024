using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07_20024.Models
{
    public class Sword : Weapon
    {
        public Sword(int damage)
        {
            Damage = damage;
        }

        public override void Attack()
        {
            Console.WriteLine($"Swing sword for {Damage}!");
        }
    }
}
