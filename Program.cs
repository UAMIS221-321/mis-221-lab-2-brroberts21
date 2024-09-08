double costOfSandwich = 4.75;
double costOfTopping = 0.55;
double discountAmount = 0.10;

static int NumberOfSandwiches(){
    Console.WriteLine("How many sandwiches?");
    
    return int.Parse(Console.ReadLine()!);
}

static int NumberOfToppings(){
    Console.WriteLine("How many toppings?");

    return int.Parse(Console.ReadLine()!);
}

static double Tip(){
    Console.WriteLine("Please enter your tip as a decimal.");

    return double.Parse(Console.ReadLine()!);
}

double totalSandwichCost = costOfSandwich * NumberOfSandwiches();
double totalToppingCost = costOfTopping * NumberOfToppings();
double baseCost = totalSandwichCost + totalToppingCost;

double orderCost = Tip() + baseCost * (1-discountAmount);

Console.WriteLine(orderCost);