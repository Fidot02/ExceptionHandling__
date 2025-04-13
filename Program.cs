
//EXCEPTION HANDLING

try
{
    Console.WriteLine("Enter a number to divide 100 by:");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int result = 100 / divisor;

    Console.WriteLine($"Result: 100 / {divisor} = {result}");
}

catch (DivideByZeroException)
{ Console.WriteLine("Error! Cannot divide by 0"); }

catch (Exception)
{ Console.WriteLine("Error! please input a valid number"); }

Console.ReadKey();