using OPPConcepts;
using OPPConcepts.Backend;

try
{
   var employee = new Employee(1, "jhon", "Doe", true, new Date(1999, 5, 15), new Date(2020, 1, 10));
    Console.WriteLine(employee);    
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


 var date1 = new Date();              //constructor sin parametros
    var date2 = new Date(2026, 2, 28);   // constructor con parametros
    var date3 = new Date(2012, 11, 30);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);