namespace InventorySeystem
{
    internal class Program

    {
        const int MaxItems = 50;
        // static int ItemCount = 0;
        static string[,] Inventory = new string[MaxItems, 3];  // 50 items,   attributes ( Id ,Name, Quantity, Price)
        static int ItemCount = 0;
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine(" Welcome TO Inventory System , Enter Your Choise ");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine(" 1. Add New Item ");
                Console.WriteLine(" 2. View All Items ");
                Console.WriteLine(" 3. Update Item ");
                Console.WriteLine(" 4. Exit ");
                Console.WriteLine("--------------------------------------------------");

                string Userinput = Console.ReadLine();
                int UserChoice = int.Parse(Userinput);

                switch (Userinput)
                {
                    case "1":
                        AddNewItem();
                        break;
                    case "2":
                        ViewAllItems();
                        break;
                    case "3":
                        UpdateItem();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice, Please Try Again.");
                        break;
                }
            }



        }

        private static void AddNewItem()
        {
            if (ItemCount >= MaxItems)
            {
                Console.WriteLine("Inventory is Full, Cannot Add More Items.");
                return;
            }

            //Console.WriteLine("Enter Item ID:");
            //string id = Console.ReadLine();
            Console.WriteLine("Enter Item Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Item Quantity:");
            string quantity = Console.ReadLine();
            Console.WriteLine("Enter Item Price:");
            string price = Console.ReadLine();
            // Inventory[ItemCount, 0] = (ItemCount + 1).ToString(); // Auto-generate ID
            Inventory[ItemCount, 0] = name;
            Inventory[ItemCount, 1] = quantity;
            Inventory[ItemCount, 2] = price;
            ItemCount++;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Item Added Successfully!");


        }
        private static void ViewAllItems()
        {
            if (ItemCount == 0)
            {
                Console.WriteLine("No Items in Inventory.");
                return;
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("ID\tName\tQuantity\tPrice");
            Console.WriteLine("--------------------------------------------------");
            for (int i = 0; i < ItemCount; i++)
            {
                Console.WriteLine($"{i + 1}\t{Inventory[i, 0]}\t{Inventory[i, 1]}\t{Inventory[i, 2]}");
            }
            Console.WriteLine("--------------------------------------------------");
        }
        private static void UpdateItem()
        {
            Console.WriteLine("Enter Item Name to Update:");
            string nameToUpdate = Console.ReadLine();
            if (ItemCount > 0)
            {
                for (int i = 0; i<ItemCount;i++)
                {
                    if (Inventory[i, 0] == nameToUpdate)
                    {
                        Console.WriteLine("Enter New Quantity:");
                        string newQuantity = Console.ReadLine();
                        Console.WriteLine("Enter New Price:");
                        string newPrice = Console.ReadLine();
                        Inventory[i, 1] = newQuantity;
                        Inventory[i, 2] = newPrice;
                        Console.WriteLine("Item Updated Successfully!");
                        return;
                    }
                }
                Console.WriteLine("Item Not Found.");
            }
            else
            {
                Console.WriteLine("No Items in Inventory.");

            }
        }
    }
}
