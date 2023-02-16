using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroRPGAssignment.Exeptions
{
    public class InvalidArmorExeption : Exception
    {
        public InvalidArmorExeption()
        {
        }

        public InvalidArmorExeption(string? message) : base(message)
        {
        }

    }
}
