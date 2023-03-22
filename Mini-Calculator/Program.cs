namespace Mini_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            byte Start = 1;
            while (Start == 1)
            {
                Operators Operator = new Operators();

                Console.WriteLine("\t\t\t A for Addition \n\t\t\t D for division \n\t\t\t M for Multiplication \n\t\t\t S for Subtraction \n");
                string Value = Console.ReadLine();
                Console.WriteLine("\n\n\n");
                if (Value == "A" || Value == "a")
                {
                    float Input1;
                    float Input2;
                    Console.WriteLine("\n\t\t\tAddition \n\t\t\t Now enter the two values you want to add, make sure they are only numbers ");
                    string input1 = Console.ReadLine();
                    while (!(float.TryParse(input1, out Input1)))
                    {
                        Console.WriteLine("\n\t\t\t Your input is invalid, Try again");
                        input1 = Console.ReadLine();
                    }
                    //string input2 = Console.ReadLine();
                    Console.WriteLine("\n\t\t\tAddition \n\t\t\t Now enter the Second value you want to add ");
                    string input2 = Console.ReadLine();
                    while (!(float.TryParse(input2, out Input2)))
                    {
                        Console.WriteLine("\n\t\t\t Your input is invalid, Try again");
                        input2 = Console.ReadLine();
                    }
                    Console.WriteLine("\n\t\t\t " + Operator.Add(Input1, Input2));
                }
                else if (Value == "D" || Value == "d")
                {
                    float Input1;
                    float Input2;
                    Console.WriteLine("\n\t\t\tDivision \n\t\t\t Now enter the two values you want to Divide, make sure the first number is the numerator and are only numbers ");
                    string input1 = Console.ReadLine();
                    while (!(float.TryParse(input1, out Input1)))
                    {
                        Console.WriteLine("\n\t\t\t Your input is invalid, please input a number, Try again");
                        input1 = Console.ReadLine();
                    }
                    //string input2 = Console.ReadLine();
                    Console.WriteLine("\n\t\t\tDivision \n\t\t\t Now enter the value of the denominator");
                    string input2 = Console.ReadLine();
                    while (!(float.TryParse(input2, out Input2)))
                    {
                        Console.WriteLine("\n\t\t\t Your input is invalid, Try again");
                        input2 = Console.ReadLine();
                    }
                    Console.WriteLine("\n\t\t\t " + Operator.Divide(Input1, Input2));
                }
                else if (Value == "M" || Value == "m")
                {
                    float Input1;
                    float Input2;
                    Console.WriteLine("\n\t\t\tMultiplication \n\t\t\t Now enter the two values you want to Multiply, make sure they are only numbers ");
                    string input1 = Console.ReadLine();
                    while (!(float.TryParse(input1, out Input1)))
                    {
                        Console.WriteLine("\n\t\t\t Your input is invalid, Try again");
                        input1 = Console.ReadLine();
                    }
                    //string input2 = Console.ReadLine();
                    Console.WriteLine("\n\t\t\tMultiply \n\t\t\t Now enter the Second value you want to Multiply ");
                    string input2 = Console.ReadLine();
                    while (!(float.TryParse(input2, out Input2)))
                    {
                        Console.WriteLine("\n\t\t\t Your input is invalid, Try again");
                        input2 = Console.ReadLine();
                    }
                    Console.WriteLine("\n\t\t\t " + Operator.Multiply(Input1, Input2));
                }
                else if (Value == "S" || Value == "s")
                {
                    float Input1;
                    float Input2;
                    Console.WriteLine("\n\t\t\tSubtraction \n\t\t\t Now enter the two values you want to Subtract, Enter the number to be subtracted from ");
                    string input1 = Console.ReadLine();
                    while (!(float.TryParse(input1, out Input1)))
                    {
                        Console.WriteLine("\n\t\t\t Your input is invalid, Try again");
                        input1 = Console.ReadLine();
                    }
                    //string input2 = Console.ReadLine();
                    Console.WriteLine("\n\t\t\tSubtraction \n\t\t\t Now enter the Second value you want to Subtract from the first one ");
                    string input2 = Console.ReadLine();
                    while (!(float.TryParse(input2, out Input2)))
                    {
                        Console.WriteLine("\n\t\t\t Your input is invalid, Try again");
                        input2 = Console.ReadLine();
                    }
                    Console.WriteLine("\n\t\t\t " + Operator.Subtract(Input1, Input2));
                }

                Console.WriteLine("Press 1 to start another operation or any other key to end the operation");
                string Value1 = Console.ReadLine();
                //int Value2 = int.Parse(Value1);
                //Console.WriteLine(Value2 + 3);
                if (Value1 == "1")
                {
                    Start = 1;
                }
                else
                {
                    Start = 0;
                }
            }
        }
    }
}