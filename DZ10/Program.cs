namespace DZ10
{
    using System;

    /// <summary>
    ///  This class performs an important function.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            ConfectionSet set1 = new ConfectionSet();
            set1.AddToSet(new Chocolats("FFF", 200, Colour.Black, true, DateTime.Now.AddMonths(12)));
            set1.AddToSet(new Chocolats("FAF", 180, Colour.Black, true, DateTime.Now.AddMonths(12)));
            set1.AddToSet(new Bisquits("BBB", 450, PackType.Box, DateTime.Now.AddMonths(1)));
            set1.AddToSet(new Bisquits("BB2", 450, PackType.Gravimetric, DateTime.Now.AddMonths(1)));

            ICalcWeight setWeight = set1 as ICalcWeight;
            Console.WriteLine($"Общий вес набора {setWeight.CalcWeight().ToString()} грамм.");

            ICalcExpirationDate setExpDate = set1 as ICalcExpirationDate;
            Console.WriteLine($"Срок годности заканчивается {setExpDate.CalcExpirationDate().ToString()}.");

            ConfectionSet set2 = new ConfectionSet();

            Chocolats choco1 = new Chocolats("FFF", 180, Colour.Black, true, DateTime.Now.AddMonths(4));
            set2.AddToSet(choco1);
            set2.AddToSet(choco1);
            set2.AddToSet(choco1);

            Bisquits bisq1 = new Bisquits("BBB", 450, PackType.Box, DateTime.Now.AddMonths(2));
            set2.AddToSet(bisq1);
            set2.AddToSet(bisq1);

            setWeight = set2 as ICalcWeight;
            Console.WriteLine($"Общий вес набора {setWeight.CalcWeight().ToString()} грамм.");

            setExpDate = set2 as ICalcExpirationDate;
            Console.WriteLine($"Срок годности заканчивается {setExpDate.CalcExpirationDate().ToString()}.");
        }
    }
}
