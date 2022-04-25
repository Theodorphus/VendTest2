using Xunit;
using TestProjectVend;
using System;
using VendMachine3;

namespace TestProjectVend
{
    public class UnitTest1
    {
        [Fact]
        public bool checkTotal()
        {

            var drinkMachine = new DrinkMachine();

            int MoneyPool = 120;
            int minCost = 100;

            if (MoneyPool >= minCost)
                return true;
            else
                return false;

            Assert.Equal(true, drinkMachine.checkTotal());



        }

        [Theory]
        [InlineData(1)]
        public void InsertMoney(int money)
        {

            int[] cash = { 1, 5, 10, 20, 50, 100, 500, 1000 };

            int MoneyPool = cash[money];
            switch (money)
            {
                case (1):
                    MoneyPool += cash[0];
                    break;

                    Assert.Equal(1, MoneyPool);

            }
        }


        [Theory]
        [InlineData('C')]

        public void Purchase(char selection)
        {

            Console.WriteLine();

            bool keepRun = true;

            int MoneyPool = 120;
            int cCost = 100;
            int currPool = 0;

            while (keepRun)
            {

                switch (selection)
                {
                    case 'C':

                        if (MoneyPool > cCost)
                        {

                            Console.WriteLine("Thank you for your purchase");

                            currPool = MoneyPool - cCost;

                            Console.WriteLine(currPool);

                        }
                        else
                        {
                            Console.WriteLine("Money too low");
                        }

                        keepRun = false;



                        break;

                        Assert.Equal((int)MoneyPool, currPool);
                }
            }
        }

        [Theory]
        [InlineData('E')]


        public void EndTransaction(char printChange)
        {

            DrinkMachine machine = new DrinkMachine();

            int currPool = 0;



            Console.WriteLine("\nCurrent credit = " + currPool);

            Console.WriteLine("\nPress E to exit or S to continue shopping");



            if (printChange == 'E')
            {

                Console.WriteLine("Thank you for shopping. Your change is {0:C}", (currPool));




            }

        }

        [Theory]
        [InlineData("Cola", 120)]


        public void Examine(String Name, int Price)
        {

            DrinkMachine machine = new DrinkMachine();



            Console.WriteLine("\nThis is a " + Name + " And it costs " + Price + "kr");


        }





    }
}





