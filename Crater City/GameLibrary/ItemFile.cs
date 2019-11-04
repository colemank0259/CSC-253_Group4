using System;
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
            string id = null;
            string description = null;

            try
            {
                List<Item> myItems = new List<Item>();

                List<string> lines = File.ReadAllLines("Item.csv").ToList();

                foreach (var line in lines)
                {
                    string[] splitter = line.Split(',');

                    Item newItem = new Item(id, description);

                    newItem.ID = splitter[0];
                    newItem.Description = splitter[1];

                    // TODO may use Item.cs a parent for more specific classes and files (i.e. keys, disguises, etc.), replacing the current Items.csv file in the near future.

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
