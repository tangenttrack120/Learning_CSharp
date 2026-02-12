using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!"); //this will give output of the line in the console
            Console.WriteLine("I'm new to c#, I am Learning C#"); //Write is used to print the output in the console
            Console.WriteLine("It's mid"); //Line makes a new line after the output
            Console.WriteLine(5 + 3 * 5);
            Console.Write("Hello World! ");
            Console.WriteLine("This will be printed in the same line as 'Hello World!'");
            
            /* To declare variable use this syntax
             * type variableName = value;
             * C# variable type: int, double, char, string, bool
             * const used so the variable is unchangeable A.K.A Read-only
             * character use single-quote (') while string use double-quote (")
             */
            
            const char initial = 'R';
            int age = 19;
            const bool male = true;
            double myDouble = 18.8;
            const string firstName = "Richard";
            const string lastName = "Victor";
            string fullName =  firstName + " " + lastName;
            
            // you can add more variables to write using '+'
            Console.WriteLine("Hello " + fullName);
            
            // you can add multiple variables
            int x = 10;
            int y = x + 5;
            int z = x * 3;
            Console.WriteLine(x + y + z);
            
            //if you storing less than 7 decimal digits use float instead of double for less memory consumption
            //if you storing a huge amount of non decimal numbers use long for more memory alocation
            long longNum = 150000000000L;
            float floatNum = 3.14f;
            
            /* Implicit Casting: converting a smaller type to a larger type size
             * char -> int -> long -> float -> double
             * Explicit Casting: converting a larger type to a smaller type size
             * double -> float -> long -> int -> char
             */
            
            int imInt = 9;
            double imDouble = imInt;
            Console.WriteLine(imDouble); // result will be 9, this is example of Implicit Casting
            
            double exDouble = 9.89D;
            int exInt = (int) exDouble;
            Console.WriteLine(exInt); // result will be 9, this is example of Explicit Casting
            
            //Type Conversion Method
            int conertInt = 10;
            double convertDouble = 5.25;
            bool convertBool = true;

            Console.WriteLine(Convert.ToString(conertInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(conertInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(convertDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(convertBool));   // convert bool to string
            
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Gamer Tag: ");
            int gamerTag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Verify Username: " +  username);
            Console.WriteLine("Verify Tag: " +  gamerTag);
            
            //Arithmetic Operators in C# is like any other languages:
            /*
             * '+' addition operator
             * '-' substraction operator
             * '*' multiplication operator
             * '/' division operator
             * '%' modulus operator
             * '++' increament operator
             * '--' decreament operator
             */
            
            //Assignment opreators in c#
            /*
             * '=' assignment operator, ex. "x = 5" is the same as "x = 5"
             * '+=' addition assignment operator, ex. "x += 3" is the same as "x = x + 3"
             * '-=' substraction assignment operator, ex. "x -= 3" is the same as "x = x - 3"
             * '-=' multiplication assignment operator, ex. "x *= 3" is the same as "x = x * 3"
             * '-=' division assignment operator, ex. "x /= 3" is the same as "x = x / 3"
             * '-=' modulus assignment operator, ex. "x %= 3" is the same as "x = x % 3"
             * '-=' Bitwise AND assignment operator, ex. "x &= 3" is the same as "x = x & 3"
             * '-=' Bitwise OR assignment operator, ex. "x |= 3" is the same as "x = x | 3"
             * '-=' Bitwise XOR assignment operator, ex. "x ^= 3" is the same as "x = x ^ 3"
             * '-=' Right Shift assignment operator, ex. "x >>= 3" is the same as "x = x >> 3"
             * '-=' Left Shift assignment operator, ex. "x <<= 3" is the same as "x = x << 3"
             */
            
            //Comparison Operators in C# is like any other languages
            /*
             * '==' Equal to comparison operator
             * '!=' Not equal to comparison operator 
             * '>' Greater than comparison operator
             * '<' Less than comparison operator
             * '>=' Greater than equal to comparison operator
             * '<=' Less than equal to comparison operator
             */
            
            //Logical Operators in c# is like any other languages
            /*
             * '&&' logical and operator, Returns true if both statements are true
             * '||' logical or operator, Returns true if one of the statements is true
             * '!' logical not operator, Reverse the result, returns false if the result is true
             */
            
            //C# Math class
            /*
             * Math.Max(x,y), find highest value of x and y
             * Math.Min(x,y), find lowest value of x and y
             * Math.sqrt(x), returns the square roots of x
             * Math.Abs(x), method returns the absolute value of x
             * Math.Round(), rounds a number to the nearest whole number
             */
            
            string greeting = "Hello"; //strings: variable contains a collection of characters surrounded by double quotes
            int textLength = greeting.Length; //returns the length of string variable named greeting
            string upGreeting = greeting.ToUpper(); //Makes string variable named greeting uppercased
            string lowGreeting = greeting.ToLower(); //Makes string variable named greeting lowercased
            //'+' operator can be used between strings to combine them. This is called concatenation
            //you can also use "string.Concat()" to concatenate two strings
            //string interpolation: subtitutes the values of variables into placeholders in a string
            fullName = $"{firstName} {lastName}";
            
            //Access string: you can access the characters in a string by referring index number inside a square brackets []
            Console.WriteLine(fullName[0]);
            //you can also find index position of a spesific character in a string by using "IndexOf()" method
            Console.WriteLine(fullName.IndexOf('V'));
            //"Substring()" method extract the characters from a string, starting from a specified index. This method often used together with "IndexOf()".
            int lastNamePosition = fullName.LastIndexOf('V');
            string userLastName = fullName.Substring(lastNamePosition);
            Console.WriteLine(userLastName);
            // special character for string manipulation
            /*
             * "\' \'", result: '', purpose: inserting single quote
             * "\" \"", result: "", purpose: inserting double quotes
             * "\\", result: \, purpose: inserting backslash
             * "\n", result: new line, purpose: inserting a new line in a string
             * "\t", result: Tab, purpose: inserting Tab in the string
             * "\b", result: Backspace, purpose: backspace
             */
            
            


        }
    }
}