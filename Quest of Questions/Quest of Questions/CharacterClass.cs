using System;
using System.Collections.Generic;
using System.Text;

namespace Quest_of_Questions
{
    class CharacterClass
    {

        private string characterName;
        private string classType;
        private double health;
        private int goldHolding;
        private int itemHoldingNumber;
        private int humanItemLimit = 5;
        private int 


        public string CharacterName
        {
            get
            {
                return this.characterName;
            }
            set
            {
                this.characterName = value;
            }
        }

        public string ClassType
        {
            get
            {
                return this.classType;
            }
            set
            {
                this.classType = value;
            }
        }
        public int GoldHolding
        {
            get
            {
                return this.goldHolding;
            }
            set
            {
                this.goldHolding = value;
            }
        }

        public double Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public int ItemHoldingNumber
        {
            get
            {
                return this.itemHoldingNumber;
            }
            set
            {
                this.itemHoldingNumber = value;
            }
        }

        public string HealthInfo
        {
            get
            {
                if (this.health < 0)
                {
                    return "You are dead";
                }
                if (this.health >= 1 && this.health <= 3)
                {
                    return "Warning, Very Low Health. Healing will soon be nessary for survival.";
                }
                return this.characterName;
            }
            set
            {
                this.characterName = value;
            }
        }

        public CharacterClass(string name, string classType, double health, int goldHolding, int itemHoldingNumber)
        {
            this.CharacterName = name;
            this.ClassType = classType;
            this.Health = health;
            this.GoldHolding = goldHolding;
            this.ItemHoldingNumber = itemHoldingNumber; 
        }
    }
}