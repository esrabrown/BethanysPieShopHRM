


using BethanysPieShopHRM;

Console.WriteLine("Creating an employee");
Console.WriteLine("---------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime (1979, 1, 16), (25));

bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork(5);


double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");



Console.WriteLine("\n Creating an employee");
Console.WriteLine("---------------------\n");

Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), (30));

george.DisplayEmployeeDetails();

george.PerformWork();
george.PerformWork(3);
george.PerformWork(8);

double receivedWageGeorge = george.ReceiveWage(true);