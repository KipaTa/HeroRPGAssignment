using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroRPGAssignment.Attributes
{
    public class ArmorAttributes : HeroAttributes
    {
        public ArmorAttributes(int strength, int dexterity, int intelligence) : base(strength, dexterity, intelligence)
        {
        }
    }
}
