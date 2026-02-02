{
    Console.WriteLine("Hello World");
    Console.WriteLine("this is a simple bill calculator");

    Console.Write("enter quantity: ");
    string userQuantity = Console.ReadLine();
    int finalQuantity = Convert.ToInt32(userQuantity);

    Console.Write("enter item price: ");
    string userPrice = Console.ReadLine();
    double subTotal = Convert.ToDouble(userPrice)*finalQuantity;

    Console.Write("enter tax percentage: ");
    string userTax = Console.ReadLine();
    double amount = Convert.ToDouble(userTax);
    double taxAmount = (double) subTotal*(amount/100);
    double finalPrice = (double) subTotal + taxAmount;
    
    Console.WriteLine("your final is " + subTotal + ", and your tax is " + taxAmount + ", and your final price is " + finalPrice);
}