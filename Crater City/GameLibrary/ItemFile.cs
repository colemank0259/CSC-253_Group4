﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameLibrary
{
    public class ItemFile
    {
        public static List<Item> GetItems()
        {
            // Local variables
            int id = 0;
            string name = null;

            try
            {
                List<Item> myItems = new List<Item>();

                List<string> lines = File.ReadAllLines("Items.csv").ToList();

                foreach (var line in lines)
                {
                    string[] splitter = line.Split(',');

                    Item newItem = new Item(id, name);

                    newItem.ID = int.Parse(splitter[0]);
                    newItem.Name = splitter[1];

                    // TODO Use Item.cs a parent for more specific classes and files (i.e. keys, disguises, etc.), replacing the current Items.csv file.

                    myItems.Add(newItem);
                }

                return myItems;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data Read Error from ItemFile.cs");
                throw new ApplicationException("Data Read Error from ItemFile.cs", ex);
            }
        }
    }
}
