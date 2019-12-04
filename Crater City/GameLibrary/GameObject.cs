using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class GameObject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static Room CurrentRoom { get; set; }

        public GameObject(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
