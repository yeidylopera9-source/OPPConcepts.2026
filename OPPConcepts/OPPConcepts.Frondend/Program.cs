using OPPConcepts;
using OPPConcepts.Backend;

try
{
   var employees = new List<Employee>();
   decimal payroll = 0;
   var employee1 = new SalaryEmployee(1010, "Maria", "Perez", true, new Date(1999, 5, 15), new Date(2020, 1, 10), 2500000);
   employees.Add(employee1);
   var employee2 = new SalaryEmployee(2020, "Joaquin", "Gonzales", true, new Date(1980, 3, 15), new Date(2016, 11, 10), 10395250);
   employees.Add(employee2);
   var employee3 = new HourlyEmployee(3030, "Ana", "Lopez", true, new Date(1970, 3, 15), new Date(2015, 11, 20), 18000, 95);
   employees.Add(employee3);
   var employee4 = new HourlyEmployee(4040, "Kevin", "Rua", true, new Date(1970, 3, 15), new Date(2015, 11, 20), 10000, 112);
   employees.Add(employee3);


    foreach (var employee in employees)
    {
        Console.WriteLine(new string('-', 47));
        Console.WriteLine(employee);
        payroll += employee.GetValueToPlay();
    }

    Console.WriteLine(new string('=', 47));
    Console.WriteLine($"Payroll..................: {payroll,20:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


// var date1 = new Date();              //constructor sin parametros
   // var date2 = new Date(2026, 2, 28);   // constructor con parametros
  //  var date3 = new Date(2012, 11, 30);

  //  Console.WriteLine(date1);
  //  Console.WriteLine(date2);
 //   Console.WriteLine(date3);