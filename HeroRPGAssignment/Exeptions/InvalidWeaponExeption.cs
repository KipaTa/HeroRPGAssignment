using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroRPGAssignment.Exeptions
{
    public class InvalidWeaponExeption : Exception
    {

        public InvalidWeaponExeption() { }
        public InvalidWeaponExeption(string? message) : base(message)
        {
        }
    }
}
