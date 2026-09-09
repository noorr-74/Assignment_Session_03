using System;

class program
{
    static void main(String[] args)
    {

        #region Q1
        void Q1(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 3 == 0 && x % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");
        }
        #endregion

        #region Q2
        void Q2(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Negative");
            }
            else
                Console.WriteLine("positive");
        }
        #endregion

        #region Q3
        void Q3(int x,int y,int z)
        {
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            int max = x;

            if (y > max) { max = y; }
            if (z> max) { max = z; }

            int min = x;

            if (y < min) { min = y; }
            if (z < min) { min = z; }

            Console.WriteLine("the max is :" + max);
            Console.WriteLine("the min is : " + min);

        }
        #endregion

        #region Q4
        void Q4(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
                Console.WriteLine("Odd number");
        }

        #endregion

        #region Q5
        void Q5(char c)
        {
            c = Convert.ToChar(Console.ReadLine());
            if (c == 'o' || c == 'a' || c == 'u' || c == 'e' || c == 'i' )
            {
                Console.WriteLine("Vowel");

            }
            else
                Console.WriteLine("constant");
        }
        #endregion

        #region Q6
        void Q6(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.Write(i);
                if (i < x)
                    Console.WriteLine(" ,");
            }
        }
        #endregion

        #region Q7
        void Q7(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= 12; i++)
                
            {
                Console.WriteLine(x * i);
            }
        }
        #endregion

        #region Q8
        void Q8(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i <=x;i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        #endregion

        #region Q9
        void Q9(int x,int y)
        {
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            int result=1;
            for (int i = 1; i <= y; i++)
            {
               result*= x ;
            }
            Console.WriteLine(result);
        }
        #endregion

        #region Q10
        void Q10()
        {
           int total=0;
           for (int i = 0; i < 5; i++)
            {
               int  mark = Convert.ToInt32(Console.ReadLine());
               total += mark;
            }
       
            int average = total / 5;
            int percentage = total / 5;

            Console.WriteLine("Total marks = " + total);
            Console.WriteLine("Average Marks = " + average);
            Console.WriteLine("Percentage = " + percentage);

        }
        #endregion

        #region Q11
        void Q11(int x)
        {
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 2:
                    Console.WriteLine("there are 28 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("there is 30 days");
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 10:
                case 12:
                    Console.WriteLine("there is 31 days");
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }
        }
        #endregion

        #region Q12

        void Q12()
        {
            Console.WriteLine("Choose one operation (+, -, *, /)");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Write two numbers");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            switch (c)
            {
                case '+':
                    Console.WriteLine("The result is: " + (x + y));
                    break;

                case '-':
                    Console.WriteLine("The result is: " + (x - y));
                    break;

                case '*':
                    Console.WriteLine("The result is: " + (x * y));
                    break;

                case '/':
                    if (y != 0)
                        Console.WriteLine("The result is: " + (x / y));
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;

                default:
                    Console.WriteLine("Invalid symbol");
                    break;
            }
        }
        #endregion

        #region Q13
        void Q13()
        {
            Console.WriteLine("enter a string: ");
            String str = Console.ReadLine();
            String REVstr = "";
            for(int i = str.Length-1; i >= 0; i--)
            {
                REVstr += str[i];
            }
            Console.WriteLine("the inverse string is : " + REVstr);
        }
        #endregion

        #region Q14
         void Q14()
        {
            Console.WriteLine("enter the number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int reversed = 0;
            while (x != 0)
            {
                int digit = x % 10;
                reversed *= 10 + digit;
                x /= 10;

            }
            Console.WriteLine(reversed);
        }
        #endregion

        #region Q15
        void Q15()
        {
            Console.Write("Input starting number of range: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending number of range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The prime numbers between {start} and {end} are:");

            for (int i = start; i <= end; i++)
            {
                int count = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.Write(i + " ");
                }
            }
        }
        #endregion

    }
}




