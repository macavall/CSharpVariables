namespace CSharpVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Good Document https://www.techrepublic.com/article/learn-the-basics-about-c-data-types-variables/#:~:text=variable%20is%200%3B%20the%20largest%20possible%20value%20is%2018%2C446%2C744%2C073%2C709%2C551%2C615.,Holds%2016%2Dbit%20Unicode%20characters.
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/variables

            // Declare a variable of type int
            int myInt;

            // Assign a value to the variable
            myInt = 5;

            // Declare and assign a variable of type int
            int myOtherInt = 10;

            // Declare a variable of type string
            string myString = "Hello World";

            // Declare a variable of type bool
            bool myBool = true;

            // Declare a variable of type double
            double myDouble = 5.5;

            // Declare a variable of type float
            float myFloat = 5.5f;

            // Declare a variable of type char
            char myChar = 'a';

            // Declare a variable of type decimal
            decimal myDecimal = 5.5m;

            // Declare a variable of type long
            long myLong = 2302140030000000L;

            // Declare a variable of type short
            short myShort = 5;

            // Declare a variable of type byte
            byte myByte = 5;

            // Declare a variable of type uint
            uint myUInt = 5;

            // Declare a variable of type ulong
            ulong myULong = 5;

            // Declare a variable of type ushort
            ushort myUShort = 5;

            // Declare a variable of type sbyte
            sbyte mySByte = 5;

            // Create a character array
            // This array requires the length to be set in the declaration
            // Error will occur if the line read
            // new char[] 
            // Try it! :)
            char[] myCharArray = new char[6];

            // Make myCharArray say "hello"
            myCharArray[0] = 'h';
            myCharArray[1] = 'e';
            myCharArray[2] = 'l';
            myCharArray[3] = 'l';
            myCharArray[4] = 'o';
            myCharArray[5] = '!';

            Console.ReadLine();

            // To know how many bits are in a variable we
            // can use the sizeof() Method

            // 8 bits in a byte
            // and we are going to get the number
            // of bytes from each variable

            Console.WriteLine("int: " + sizeof(int) + " bytes");
            Console.WriteLine("bool: " + sizeof(bool) + " bytes");
            Console.WriteLine("double: " + sizeof(double) + " bytes");
            Console.WriteLine("float: " + sizeof(float) + " bytes");
            Console.WriteLine("char: " + sizeof(char) + " bytes");
            Console.WriteLine("decimal: " + sizeof(decimal) + " bytes");
            Console.WriteLine("long: " + sizeof(long) + " bytes");
            Console.WriteLine("short: " + sizeof(short) + " bytes");
            Console.WriteLine("byte: " + sizeof(byte) + " bytes");
            Console.WriteLine("uint: " + sizeof(uint) + " bytes");
            Console.WriteLine("ulong: " + sizeof(ulong) + " bytes");
            Console.WriteLine("ushort: " + sizeof(ushort) + " bytes");
            Console.WriteLine("sbyte: " + sizeof(sbyte) + " bytes");

            Console.WriteLine("int: " + sizeof(int) * 8 + " bits");
            Console.WriteLine("bool: " + sizeof(bool) * 8 + " bits");
            Console.WriteLine("double: " + sizeof(double) * 8 + " bits");
            Console.WriteLine("float: " + sizeof(float) * 8 + " bits");
            Console.WriteLine("char: " + sizeof(char) * 8 + " bits");
            Console.WriteLine("decimal: " + sizeof(decimal) * 8 + " bits");
            Console.WriteLine("long: " + sizeof(long) * 8 + " bits");
            Console.WriteLine("short: " + sizeof(short) * 8 + " bits");
            Console.WriteLine("byte: " + sizeof(byte) * 8 + " bits");
            Console.WriteLine("uint: " + sizeof(uint) * 8 + " bits");
            Console.WriteLine("ulong: " + sizeof(ulong) * 8 + " bits");
            Console.WriteLine("ushort: " + sizeof(ushort) * 8 + " bits");
            Console.WriteLine("sbyte: " + sizeof(sbyte) * 8 + " bits");

        }
    }
}