using RAD302Week3Lab12026CL.S00198790;
using Tracker.WebAPIClient;

ActivityAPIClient.Track(
    StudentID: "S00198790",
    StudentName: "Ronan Keaveney",
    activityName: "Rad302 2026 Week 3 Lab 1",
    Task: "Testing Console Queries against the DB Model"
);

using var context = new CustomerDbContext();

Console.WriteLine("All Customers");
Console.WriteLine("-------------");

var customers = context.Customers.ToList();

foreach (var c in customers)
{
    Console.WriteLine($"{c.ID} | {c.Name} | {c.Address} | {c.CreditRating}");
}

Console.WriteLine();
Console.WriteLine("Customers with Credit Rating > 400");
Console.WriteLine("----------------------------------");

var highCreditCustomers = context.Customers
    .Where(c => c.CreditRating > 400)
    .ToList();

foreach (var c in highCreditCustomers)
{
    Console.WriteLine($"{c.ID} | {c.Name} | {c.Address} | {c.CreditRating}");
}

Console.WriteLine();
Console.WriteLine("Adding a new customer...");
Console.WriteLine("-------------------------");

var newCustomer = new Customer
{
    Name = "New Customer",
    Address = "Test Address",
    CreditRating = 500
};

context.Customers.Add(newCustomer);
context.SaveChanges();

Console.WriteLine("Customer added successfully.");
Console.WriteLine();

Console.WriteLine("Updated Customer List");
Console.WriteLine("---------------------");

var updatedCustomers = context.Customers.ToList();

foreach (var c in updatedCustomers)
{
    Console.WriteLine($"{c.ID} | {c.Name} | {c.Address} | {c.CreditRating}");
}