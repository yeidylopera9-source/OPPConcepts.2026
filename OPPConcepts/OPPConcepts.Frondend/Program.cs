using OPPConcepts.Backend;

try
{
    var date1 = new Date();              //constructor sin parametros
    var date2 = new Date(2026, 2, 28);   // constructor con parametros
    var date3 = new Date(2012, 11, 30);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


