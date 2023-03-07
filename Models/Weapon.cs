using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07_20024.Models
{
    public abstract class Weapon
    {
        public int Damage { get; set; }

        public abstract void Attack();
    }
}
