Console.WriteLine("Enter the Product Price :");
double price= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter The Product Quantity");
int quantity= Convert.ToInt32(Console.ReadLine());
double total= price *  quantity;
Console.WriteLine(total);
string answer;
do
{
    Console.WriteLine("do you want add another product ?");
     answer = Console.ReadLine();

    if (answer == "yes")
    {
        Console.WriteLine("Enter the Product Price :");
        price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Product Quantity");
        quantity = Convert.ToInt32(Console.ReadLine());
    }
}
while (answer=="yes");

double totalprice= total + (price * quantity);
Console.WriteLine(totalprice);


