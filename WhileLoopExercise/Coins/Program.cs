using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double changeX100 = Math.Floor(change * 100);
            double coinsCount = 0;
           
                coinsCount += Math.Floor(changeX100 / 200);
                changeX100 -= coinsCount * 200;
                if (changeX100/100 >=1)
                {
                    coinsCount += Math.Floor(changeX100 / 100);
                    changeX100 -= 100;
                }
                if (changeX100 / 50>=1)
                {
                    coinsCount += Math.Floor(changeX100 / 50);
                    changeX100 -= 50;
                }
                if (changeX100 / 40 >= 1)
                {
                    coinsCount += Math.Floor(changeX100 / 40);
                    changeX100 -= 20;
                }
                if (changeX100 / 20 >= 1)
                {
                    coinsCount += Math.Floor(changeX100 / 20);
                    changeX100 -= 20;
                }
                if (changeX100 / 10 >= 1)
                {
                    coinsCount += Math.Floor(changeX100 / 10);
                    changeX100 -= 10;
                }
                if (changeX100 / 5 >= 1)
                {
                    coinsCount += Math.Floor(changeX100 / 5);
                    changeX100 -= 5;
                }
                if (changeX100 / 4 >= 1)
                {
                    coinsCount += Math.Floor(changeX100 / 4);
                    changeX100 -= 2;
                }
                if (changeX100 / 2 >= 1)
                {
                    coinsCount += Math.Floor(changeX100 / 2);
                    changeX100 -= 2;
                }
                if (changeX100>0)
                {
                    coinsCount++;
                }
            
                   Console.WriteLine(coinsCount);
        }
    }
}
