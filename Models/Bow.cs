using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07_20024.Models
{
    public class Bow : Weapon
    {
        public Bow(int damage)
        {
            Damage = damage;
        }

        public override void Attack()
        {
            Console.WriteLine($"Shoots bow for {Damage}!");
        }
    }
}
