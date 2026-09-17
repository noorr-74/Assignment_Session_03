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

        #region Q16
        void Q16()
        {
            Console.Write("Enter a number to convert: ");
            int decNum = Convert.ToInt32(Console.ReadLine());

            string binaryStr = "";
            int tempDec = decNum;

            if (tempDec == 0)
            {
                binaryStr = "0";
            }

            while (tempDec > 0)
            {
                binaryStr = (tempDec % 2) + binaryStr;
                tempDec /= 2;
            }

            Console.WriteLine("The Binary of " + decNum + " is " + binaryStr);
        }
        #endregion

        #region Q17
        void Q17()
        {
            Console.Write("Enter x1 y1: ");
            string[] point1 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(point1[0]);
            int y1 = Convert.ToInt32(point1[1]);

            Console.Write("Enter x2 y2: ");
            string[] point2 = Console.ReadLine().Split(' ');

            int x2 = Convert.ToInt32(point2[0]);
            int y2 = Convert.ToInt32(point2[1]);

            Console.Write("Enter x3 y3: ");
            string[] point3 = Console.ReadLine().Split(' ');

            int x3 = Convert.ToInt32(point3[0]);
            int y3 = Convert.ToInt32(point3[1]);

            if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            {
                Console.WriteLine("Points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("Points do not lie on a single straight line.");
            }
        }
        #endregion

        #region Q18
        void Q18()
        {
            Console.Write("Enter time taken in hours: ");
            double hours = Convert.ToDouble(Console.ReadLine());

            if (hours >= 2 && hours <= 3)
            {
                Console.WriteLine("Highly efficient");
            }
            else if (hours > 3 && hours <= 4)
            {
                Console.WriteLine("Instructed to increase speed");
            }
            else if (hours > 4 && hours <= 5)
            {
                Console.WriteLine("Provided with training to enhance speed");
            }
            else if (hours > 5)
            {
                Console.WriteLine("Required to leave the company");
            }
            else
            {
                Console.WriteLine("Invalid time entered");
            }
        }
        #endregion

        #region Q19
        void Q19()
        {
            Console.Write("Enter size n: ");
            int n19 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n19; i++)
            {
                for (int j = 0; j < n19; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }

                Console.WriteLine();
            }
        }
        #endregion

        #region Q20
        void Q20()
        {
            int[] arr20 = { 1, 2, 3, 4, 5 };
            int sum20 = 0;

            for (int i = 0; i < arr20.Length; i++)
            {
                sum20 += arr20[i];
            }

            Console.WriteLine("Sum of all elements = " + sum20);
        }
        #endregion

        #region Q21
        void Q21()
        {
            int[] arrA = { 1, 3, 5 };
            int[] arrB = { 2, 4, 6 };

            int[] merged = new int[arrA.Length + arrB.Length];

            for (int i = 0; i < arrA.Length; i++)
            {
                merged[i] = arrA[i];
            }

            for (int i = 0; i < arrB.Length; i++)
            {
                merged[arrA.Length + i] = arrB[i];
            }

            Array.Sort(merged);

            Console.Write("Merged and sorted array: ");

            for (int i = 0; i < merged.Length; i++)
            {
                Console.Write(merged[i] + " ");
            }

            Console.WriteLine();
        }
        #endregion

        #region Q22
        void Q22()
        {
            int[] arr22 = { 1, 2, 2, 3, 1, 4 };
            bool[] visited = new bool[arr22.Length];

            for (int i = 0; i < arr22.Length; i++)
            {
                if (visited[i])
                    continue;

                int count = 1;

                for (int j = i + 1; j < arr22.Length; j++)
                {
                    if (arr22[i] == arr22[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }

                Console.WriteLine(arr22[i] + " occurs " + count + " times");
            }
        }
        #endregion

        #region Q23
        void Q23()
        {
            int[] arr23 = { 5, 2, 9, 1, 7 };

            int max23 = arr23[0];
            int min23 = arr23[0];

            for (int i = 1; i < arr23.Length; i++)
            {
                if (arr23[i] > max23)
                    max23 = arr23[i];

                if (arr23[i] < min23)
                    min23 = arr23[i];
            }

            Console.WriteLine("Maximum element = " + max23);
            Console.WriteLine("Minimum element = " + min23);
        }
        #endregion

        #region Q24
        void Q24()
        {
            int[] arr24 = { 12, 35, 1, 10, 34, 1 };

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < arr24.Length; i++)
            {
                if (arr24[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr24[i];
                }
                else if (arr24[i] > secondLargest && arr24[i] != largest)
                {
                    secondLargest = arr24[i];
                }
            }

            Console.WriteLine("Second largest element = " + secondLargest);
        }
        #endregion

        #region Q25
        void Q25()
        {
            Console.Write("Enter size of array: ");
            int size25 = Convert.ToInt32(Console.ReadLine());

            int[] arr25 = new int[size25];

            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < size25; i++)
            {
                arr25[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxDist = -1;

            for (int i = 0; i < size25; i++)
            {
                for (int j = size25 - 1; j > i; j--)
                {
                    if (arr25[i] == arr25[j])
                    {
                        int dist = j - i - 1;

                        if (dist > maxDist)
                        {
                            maxDist = dist;
                        }

                        break;
                    }
                }
            }

            Console.WriteLine("Longest distance = " + maxDist);
        }
        #endregion

        #region Q26
        void Q26()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            Array.Reverse(words);

            Console.WriteLine(string.Join(" ", words));
        }
        #endregion

        #region Q27
        void Q27()
        {
            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];

            Console.WriteLine("Enter 4 elements for 2x2 matrix:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                    matrix2[i, j] = matrix1[i, j];
                }
            }

            Console.WriteLine("Second Array Elements:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
        #endregion

        #region Q28
        void Q28()
        {
            int[] arr28 = { 1, 2, 3, 4, 5 };

            Console.Write("Array in reverse order: ");

            for (int i = arr28.Length - 1; i >= 0; i--)
            {
                Console.Write(arr28[i] + " ");
            }

            Console.WriteLine();
        }
        #endregion
    }
}




