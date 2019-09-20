using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodAssignment
{
    public class CodilityTask
    {
        public static StringBuilder Solution(int a, int b, int c)
        {
            StringBuilder output = new StringBuilder();
            var count = a + b + c;

            for (int i = 0; i < count; i++)
            {
                if (a >= 3)
                {
                    output.Append("aa");
                    a = a - 2;
                    if (b >= 3)
                    {
                        output.Append("bb");
                        b = b - 2;
                        if (c >= 3)
                        {
                            c = c - 2;
                            output.Append("ccc");
                        }
                        else if (c <= 3 && c > 0)
                        {
                            while (c > 0)
                            {
                                output.Append("c");
                                c = c - 1;
                            }
                            continue;
                        }
                    }
                    else if (b < 3 && b > 0)
                    {
                        while (b > 0)
                        {
                            output.Append("b");
                            b--;
                        }
                        if (c >= 3)
                        {
                            c = c - 2;
                            output.Append("ccc");
                        }
                        else if (c <= 3 && c > 0 && c > a && c > b)
                        {
                            while (c > 0)
                            {
                                output.Append("c");
                                c = c - 1;
                            }
                            continue;
                        }
                    }

                    else if (b <= 3 && b > 0)
                    {
                        while (b > 0)
                        {
                            output.Append("b");
                            b = b - 1;
                        }

                        if (c <= 3 && c > 0 && c > a)
                        {
                            while (c > 0)
                            {
                                output.Append("c");
                                c = c - 1;
                            }
                            continue;
                        }
                        else if (a < 3 && a > 0)
                        {
                            while (a > 0)
                            {
                                output.Append("a");
                                a = a - 1;
                                continue;
                            }
                        }
                        else if (a > 3)
                        {
                            output.Append("aa");
                            a = a - 2;
                            if (b < c && b < 3 && b > 0)
                            {
                                while (b > 0)
                                {
                                    output.Append("b");
                                    b = b - 1;
                                }
                            }
                            if (c < 3 && c > 0)
                            {
                                while (c > 0)
                                {
                                    output.Append("c");
                                    c = c - 1;
                                }
                                continue;
                            }

                        }
                    }
                    else if (c <= 3 && c > 0)
                    {
                        while (c > 0)
                        {
                            output.Append("c");
                            c = c - 1;
                        }
                        continue;
                    }
                }
                else if (a < 3 && a > 0)
                {
                    while (a > 0)
                    {
                        output.Append("a");
                        a--;
                    }
                    if (b > 3)
                    {
                        output.Append("bb");
                        b = b - 2;
                        if (c > 3)
                        {
                            output.Append("cc");
                            c = c - 2;
                        }
                        else if (c < 3 && c > 0)
                        {
                            while (c > 0)
                            {
                                output.Append("c");
                                c--;
                            }
                            continue;
                        }
                    }
                    else if (b < 3 && b > 0)
                    {
                        while (b > 0)
                        {
                            output.Append("b");
                            b--;
                        }
                        if (c > 3)
                        {
                            output.Append("cc");
                            c = c - 2;
                        }
                        else if (c < 3 && c > 0)
                        {
                            while (c > 0)
                            {
                                output.Append("c");
                                c--;
                            }
                            continue;
                        }
                    }
                }
                else if (b >= 3)
                {
                    if (c - b > 3 || b - c > 0)
                    {
                        output.Append("bb");
                        b = b - 2;
                        if (c > 3)
                        {
                            output.Append("cc");
                            c = c - 2;
                        }
                        else
                        {
                            while (c > 0)
                            {
                                output.Append("c");
                                c = c - 1;
                            }
                            continue;
                        }
                    }
                }
                else if (b < 3 && b > 0)
                {
                    if (!(c - b > 3))
                    {

                        if (c > 3)
                        {
                            output.Append("cc");
                            c = c - 2;
                        }
                        while (b > 0)
                        {
                            output.Append("b");
                            b--;
                        }
                        if (c < 3 && c > 0)
                        {
                            while (c > 0)
                            {
                                output.Append("c");
                                c--;
                            }
                            continue;
                        }
                    }
                    else
                    {
                        if (c > 3)
                        {
                            output.Append("cc");
                            c = c - 2;
                        }
                        if (b - c < 0)
                        {
                            if (b < 3)
                            {
                                output.Append("b");
                                b--;
                            }
                        }
                        if (c > 3 && (a > 0 || b > 0))
                        {
                            output.Append("cc");
                            c = c - 2;
                        }
                        else if (c < 3 && c > 0)
                        {
                            while (c > 0)
                            {
                                output.Append("c");
                                c--;
                            }
                            continue;
                        }
                    }

                }
                else if (c >= 3)
                {

                    output.Append("cc");
                    c = c - 2;
                    if (a == 0 && b == 0) break;
                    continue;
                }
            }
            return output;
        }
        public static void Main()
        {
            Console.WriteLine(Solution(6, 1, 1));
            Console.WriteLine(Solution(1, 3, 1));
            Console.WriteLine(Solution(0, 1, 8));
            Console.ReadLine();
        }
    }
}
