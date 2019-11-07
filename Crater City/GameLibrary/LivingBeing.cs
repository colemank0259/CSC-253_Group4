using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class LivingBeing : GameObject
    {
        public LivingBeing(int id, string name) : base (id, name)
        {
            ID = id;
            Name = name;
        }
    }
}
