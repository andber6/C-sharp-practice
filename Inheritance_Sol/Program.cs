using Inheritance_Sol;

BankAccount sa1 = new SavingsAccount("Ola", 0.01);
sa1.Deposit(100);

BankAccount ca1 = new CurrentAccount("Kari");
sa1.Deposit(100);

ProcessBankAccount(sa1);
ProcessBankAccount(ca1);

// Polymorphic collection.
//List<BankAccount> list = new List<BankAccount>();
//list.Add(sa1);
//list.Add(ca1);
List<BankAccount> list = new List<BankAccount>{sa1, ca1};

foreach (BankAccount b in list)
{
    Console.WriteLine(b);
}

DemoLinq();

// ----------------------------------------------------------

void ProcessBankAccount(BankAccount b)
{
    //  Polymorphism.
    b.Withdraw(101);
}

// ----------------------------------------------------------

void DemoLinq()
{
    // Here's an array of strings.
    string[] cities = { "Boston", "New York", "Dallas", "St. Paul", "Las Vegas" };

    // Use a LINQ query expression to get the cities that contain a space character.
    var subset = from c in cities
                 where c.Contains(" ")
                 orderby c.Length
                 ascending
                 select c.Reverse();

    Console.WriteLine("\nCities with spaces (using LINQ): ");
    foreach (var s in subset)
        Console.WriteLine($"City: {s}");
}
