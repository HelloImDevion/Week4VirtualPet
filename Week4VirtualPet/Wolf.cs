using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4VirtualPet
{
    class Wolf
    {
        //fields
        private string wolfName;
        private int currentRest;
        private int maxRest;
        private int currentHunger;
        private int maxHunger;
        private int currentThirst;
        private int maxThirst;
        private int currentWaste;
        private int maxWaste;
    
        public string WolfName
        {
            get { return this.wolfName; }
            set { this.wolfName = value; }
        }
        public int CurrentRest
        {
            get { return this.currentRest; }
        }
        public int MaxRest
        {
            get { return this.maxRest; }
        }
        public int CurrentHunger
        {
            get { return this.currentHunger; }
        }
        public int MaxHunger
        {
            get { return this.maxHunger; }
        }
        public int CurrentThirst
        {
            get { return this.currentThirst; }
        }
        public int MaxThirst
        {
            get { return this.maxThirst; }
        }
        public int CurrentWaste
        {
            get { return this.currentWaste; }
        }
        public int MaxWaste
        {
            get { return this.maxWaste; }
        }

        public long Ticks { get; }

        public Wolf()
        {


        }

        public Wolf(string wolfName)
        {
            this.wolfName = wolfName;
            this.currentRest = 100;
            this.maxRest = 100;
            this.currentHunger = 20;
            this.maxHunger = 20;
            this.currentThirst = 20;
            this.maxThirst = 20;
            this.currentWaste = 10;
            this.maxWaste = 10;

        }

        public void MainMenu()
        {

            while (this.currentRest > 0)
            {

                Console.WriteLine(" Health = " + this.currentRest);
                Console.WriteLine(" Hunger = " + this.currentHunger);
                Console.WriteLine(" Thirst = " + this.currentThirst);
                Console.WriteLine(" Waste =  " + this.currentWaste);
              
                Console.WriteLine("Press 1 to Eat.");
                Console.WriteLine("Press 2 to Drink.");
                Console.WriteLine("Press 3 to Use The Bathroom.");
                Console.WriteLine("Press 4 to Sleep.");

                int userEnteredNumber = int.Parse(Console.ReadLine());

                if (userEnteredNumber == 1)
                {
                    this.currentHunger = this.maxHunger;
                    this.currentThirst -= 2;
                    this.currentWaste -= 2;
                    this.currentRest -= 10;
                    Console.WriteLine("Im stuffed!!");
                }
                else if (userEnteredNumber == 2)
                {
                    this.currentThirst = maxThirst;
                    this.currentHunger -= 2;
                    this.currentWaste -= 2;
                    this.currentRest -= 10;
                    Console.WriteLine("Refreshing!!");
                }
                else if (userEnteredNumber == 3)
                {
                    this.currentWaste = maxWaste;
                    this.currentHunger -= 2;
                    this.currentThirst -= 2;
                    this.currentRest -= 10;
                    Console.WriteLine("Ewww I think you should clean that up.");
                   
                }
                else if (userEnteredNumber == 4)
                {
                    this.currentRest = this.maxRest;
                    this.currentHunger -= 2;
                    this.currentThirst -= 2;
                    this.currentWaste -= 2;
                    Console.WriteLine("Ready for the day!!");
                }
            }
        }
    }
}
