using OPPConcepts;
using OPPConcepts.Backend;

try
{
   var employee1 = new SalaryEmployee(1, "Maria", "Perez", true, new Date(1999, 5, 15), new Date(2020, 1, 10), 2500000);
   var employee2 = new SalaryEmployee(1, "Joaquin", "Gonzales", true, new Date(19-0, 3, 15), new Date(2016, 11, 10), 10395250);

    Console.WriteLine(employee1);
    Console.WriteLine(employee2);

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