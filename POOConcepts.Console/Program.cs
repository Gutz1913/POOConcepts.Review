using POOConcepts.Core;

try
{
    var employee1 = new SalaryEmployee { Id = 1010, FirstName = "Andres", LastName = "Gutierrez", BornDate = new Date(1991, 08, 16), HireDate = new Date(2020, 01, 12), IsActive = true, Salary = 2315544 };

    var employee2 = new HourlyEmployee { Id = 2020, FirstName = "Carlos", LastName = "Gutierrez", BornDate = new Date(1964, 12, 15), HireDate = new Date(2000, 06, 15), IsActive = true, HourValue = 34679, WorkingHours = 200 };

    var employee3 = new CommissionEmployee { Id = 3030, FirstName = "Mercedes", LastName = "Valencia", BornDate = new Date(1967, 12, 29), HireDate = new Date(2005, 04, 30), IsActive = true, CommissionPercent = 0.03f, Sales = 527000000 };

    var employee4 = new BaseCommissionEmployee { Id = 4040, FirstName = "Sebastián", LastName = "Valencia", BornDate = new Date(2004, 06, 10), HireDate = new Date(2024, 03, 21), IsActive = true, CommissionPercent = 0.015f, Sales = 89568000, Salary = 800000 };

    var invoice1 = new Invoice { Id = 1, Description = "Computer Asus R55", Price = 4500000, Quantity = 3 };
    var invoice2 = new Invoice { Id = 2, Description = "Avocado", Price = 5321, Quantity = 5.68f };
    var invoice3 = new Invoice { Id = 3, Description = "Gamer Chair", Price = 1250000, Quantity = 5 };

    var items = new List<IPay> { employee1, employee2, employee3, employee4, invoice1, invoice2, invoice3 };
    decimal total = 0;

    foreach (var item in items)
    {
        Console.WriteLine(item);
        Console.WriteLine();
        total += item.GetValueToPay();
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
