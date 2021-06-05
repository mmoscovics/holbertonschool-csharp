using System;

namespace InventoryLibrary
{
/// Inventory Class ///
    public class Inventory : BaseClass
    {
        public string user_id{get; set;}
        public string item_id{get; set;}
        public int quantity = 1;

        /// Constructor ///
        public Inventory(string user_id, string item_id)
        {
            this.user_id = user_id;
            this.item_id = item_id;
        }
    }
}
