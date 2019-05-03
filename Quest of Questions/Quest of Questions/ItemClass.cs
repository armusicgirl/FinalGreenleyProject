using System;
using System.Collections.Generic;
using System.Text;

namespace Quest_of_Questions
{
    class ItemClass
    {
        private string itemName;
        private string itemDescription;
        private int itemValue;
        private int itemWearLevel;

 
        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                this.itemName = value;
            }
        }
        public string ItemDescription
        {
            get
            {
                return itemDescription;
            }
            set
            {
                this.itemDescription = value;
            }
        }
        public int ItemValue
        {
            get
            {
                return itemValue;
            }
            set
            {
                this.itemValue = value;
            }
        }
        public int ItemWearLevel
        {
            get
            {
                return itemWearLevel;
            }
            set
            {
                this.itemWearLevel = value;
            }
        }

        public ItemClass(string itemName, string itemDescription, int itemValue, int itemWhearLevel)
        {
            this.ItemName = itemName;
            this.ItemDescription = itemDescription;
            this.ItemValue = itemValue;
            this.ItemWearLevel = itemWhearLevel;
        }
    }
}

