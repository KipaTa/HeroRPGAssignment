using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroRPGAssignment.Attributes
{
    public class TotalLevelAttributes : ArmorAttributes
    {
        public TotalLevelAttributes(int strength, int dexterity, int intelligence) : base(strength, dexterity, intelligence)
        {
        }
    }
}
