using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Mob : LivingBeing
    {
        // TODO copy Mobs and add position and movement; may need addtional class

        //public int ID { get; set; }
        //public string Description { get; set; }
        public int Damage { get; set; }
        public int AC { get; set; }
        public int HP { get; set; }

        public Mob(int id, string name, int damage, int ac, int hp) : base(id, name)
        {
            //ID = id;
            //Description = description;
            Damage = damage;
            AC = ac;
            HP = hp;
        }

        public Mob(Mob copy) : base(copy.ID, copy.Name)
        {
           Damage = copy.Damage;
            AC = copy.AC;
            HP = copy.HP;
        }
    }
}
