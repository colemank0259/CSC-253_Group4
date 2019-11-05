using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Item : GameObject
    {
        // TODO may be used as a parent for more specific classes and files (i.e. keys, disguises, etc.), replacing the current Items.csv file in the near future.

        //public string ID { get; set; }
        //public string Description { get; set; }

        public Item(int id, string name) : base(id, name)
        {
            ID = id;
            Name = name;
        }
    }
}
