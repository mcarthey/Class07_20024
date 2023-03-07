using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07_20024.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Weapon CarriedWeapon { get; set; }

        public Player(string name, Weapon weapon)
        {
            Name = name;
            CarriedWeapon = weapon;
        }

        public void UseWeapon()
        {
            CarriedWeapon.Attack();
        }
    }
}
