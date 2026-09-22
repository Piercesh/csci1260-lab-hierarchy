namespace The_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("EMBERLY ARMORY : VAULT REPORT");
            Console.WriteLine("===========================");
            Console.WriteLine();

            PlainGear sword = new PlainGear("WPN014", "Frostglass Dagger", 100.00m, 5, 8.5, 12);
            EnchantedGear staff = new EnchantedGear("P0T100", "Healing draught", 250.00m, 10, 15.0, 24);
            Consumable potion = new Consumable("SUP044", "Torch Bundle", 50.00m, 2, 5.0);
            Armory armory = new Armory("SHD002");

            armory.Add(sword);
            armory.Add(staff);
            armory.Add(potion);

            ///This is what will show the names of the weapons and potion
            Console.WriteLine(sword.Describe());
            Console.WriteLine(staff.Describe());
            Console.WriteLine(potion.Describe());
            Console.WriteLine();

            sword.Receive(3);
            sword.Release(1);

            potion.Release(1);
            potion.Receive(5);

            Console.WriteLine("Sword Movement History:");
            Console.WriteLine(sword.MovementLines);

            Console.WriteLine("Potion Movement History:");
            Console.WriteLine(potion.MovementLines);

            Console.WriteLine($"Staff Value: {sword.ExtendedValue():C}");
            Console.WriteLine($"Staff Value: {staff.ExtendedValue():C}");
            Console.WriteLine($"Potion Value: {potion.ExtendedValue():C}");
            Console.WriteLine($"Armory Total: {armory.TotalValue():C}");

            Console.WriteLine();

            IDiscountable enchanted = staff;
            Console.WriteLine($"Enchanted Staff on Sale: " +
                $"{enchanted.IsOnSale}");
            Console.WriteLine($"enchanted staff Sale Price: " +
                $"{enchanted.SalePrice():C}");
            IDiscountable consumable = potion;
            Console.WriteLine($"Potion Sale Price: " +
                $"{consumable.SalePrice():C}");
            Console.WriteLine();

            Holding found = armory.Find("WPN014");
            if (found != null)
            {
                Console.WriteLine($"Found: {found.Describe()}");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
            Console.WriteLine();

            armory.PrintReport();
            Console.WriteLine();

            armory.SortByValue();
            armory.PrintReport();
            Console.WriteLine();

            IReportable reportableSword = sword;
            IReportable reportableArmory = armory;
            Console.WriteLine(reportableSword.ReportLine());
            Console.WriteLine(reportableArmory.ReportLine());
            Console.WriteLine();

            Console.WriteLine("-------------------------");
            Console.WriteLine(sword.ToString());
            Console.WriteLine(staff.ToString());
            Console.WriteLine(potion.ToString());

        }

        static void Show(IReportable r)
        {
                       Console.WriteLine(r.ReportLine());
        }
    }
}