Console.WriteLine("Enter Cutomer Type (Regular, Silver, Gold): ");
string customerType = Console.ReadLine();

Console.WriteLine("Enter Bill Amount: ");
double billAmount = Convert.ToDouble(Console.ReadLine());

double baseDiscountRate = 0;
double extraDiscountRate = 0;

switch (customerType.ToLower())
{
    case "gold":
        baseDiscountRate = 0.20;
        extraDiscountRate = 0.05;
        break;

    case "silver":
        baseDiscountRate = 0.10;
        extraDiscountRate = 0.03;
        break;

    case "regular":
        baseDiscountRate = 0.05;
        extraDiscountRate = 0.02;
        break;
    default:
        Console.WriteLine("Unknown Client");
        return;

}
double baseDiscount = billAmount * baseDiscountRate;
double extraDiscount = 0;

if (billAmount > 100)
{
    extraDiscount = billAmount * extraDiscountRate;
}

//total discount
double totalDiscount = baseDiscount + extraDiscount;
//final price
double finalPrice = billAmount - totalDiscount;
//show results
Console.WriteLine("Results");
Console.WriteLine($"Total Discount: {totalDiscount} JD");
Console.WriteLine($"Final Price: {finalPrice} JD");