using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Item
    {
        //List<string> items = new List<string>() {"Disguise", "Office Lunch", "Key Card", "ID Card"};

        public int ID { get; set; }
        public string Description { get; set; }

        public Item(int id, string description)
        {
            ID = id;
            Description = description;
        }
    }
}
