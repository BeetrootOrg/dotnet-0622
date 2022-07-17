using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp

{
    class BigNumber
    {
        //  private readonly string _number;
        public string _number;
        public BigNumber()
        { }

        public BigNumber(string number)
        {
            _number = number;
        }

        public static BigNumber operator +(BigNumber number, BigNumber number2)
        {

            var firstlist = Program.ToIntList(number._number);
            var secondlist = Program.ToIntList(number2._number);
            int tempvumi = 0;

            if (firstlist.Count == secondlist.Count)
            {
                var resultlist = new int[firstlist.Count];

                for (int i = secondlist.Count - 1; i >= 0; i--)
                {
                    if (firstlist[i] + secondlist[i] + tempvumi >= 10)
                    {
                        resultlist[i] = (firstlist[i] + secondlist[i] + tempvumi) % 10;
                        tempvumi = 1;
                    }
                    else if (firstlist[i] + secondlist[i] + tempvumi < 10)
                    {
                        resultlist[i] = firstlist[i] + secondlist[i] + tempvumi;
                        tempvumi = 0;
                    }

                }
                return new BigNumber(string.Join("", resultlist));

            }

            if (firstlist.Count > secondlist.Count)
            {
                var resultlist = new int[firstlist.Count];
                for (int i = 0; i < firstlist.Count; i++)
                {
                    resultlist[i] = firstlist[i];
                }
                for (int i = secondlist.Count - 1, j = firstlist.Count - 1; i >= 0; i--, j--)
                {
                    if (firstlist[j] + secondlist[i] + tempvumi >= 10)
                    {
                        resultlist[j] = (firstlist[j] + secondlist[i] + tempvumi) % 10;
                        tempvumi = 1;
                    }
                    else if (firstlist[j] + secondlist[i] + tempvumi < 10)
                    {
                        resultlist[j] = firstlist[j] + secondlist[i] + tempvumi;
                        tempvumi = 0;
                    }
                    if (i == 0)
                    {
                        resultlist[j - 1] = firstlist[j - 1];
                        if (tempvumi != 0)
                        {
                            resultlist[j - 1] += 1;
                        }
                    }
                }

                return new BigNumber(string.Join("", resultlist));

            }

            if (firstlist.Count < secondlist.Count)
            {
                var resultlist = new int[secondlist.Count];
                for (int i = 0; i < secondlist.Count; i++)
                {
                    resultlist[i] = secondlist[i];
                }
                for (int i = firstlist.Count - 1, j = secondlist.Count - 1; i >= 0; i--, j--)
                {
                    if (secondlist[j] + firstlist[i] + tempvumi >= 10)
                    {
                        resultlist[j] = (secondlist[j] + firstlist[i] + tempvumi) % 10;
                        tempvumi = 1;
                    }
                    else if (secondlist[j] + firstlist[i] + tempvumi < 10)
                    {
                        resultlist[j] = secondlist[j] + firstlist[i] + tempvumi;
                        tempvumi = 0;
                    }
                    if (i == 0)
                    {
                        resultlist[j - 1] = secondlist[j - 1];
                        if (tempvumi != 0)
                        {
                            resultlist[j - 1] += 1;
                        }
                    }
                }

                return new BigNumber(string.Join("", resultlist));
            }

            return new BigNumber();

        }

        public static BigNumber operator -(BigNumber number1, BigNumber number2)
        {

            var firstlist = Program.ToIntList(number1._number);
            var secondlist = Program.ToIntList(number2._number);




            if (firstlist.Count >= secondlist.Count)
            {
                var resultlist = firstlist.ToArray();


                for (int i = secondlist.Count - 1, j = firstlist.Count - 1; i >= 0; i--, j--)
                {


                    if (secondlist[i] <= firstlist[j])
                    {
                        resultlist[j] = firstlist[j] - secondlist[i];
                    }

                    if (secondlist[i] > firstlist[j])
                    {
                        firstlist[j - 1] -= 1;
                        resultlist[j] = (firstlist[j] + 10) - secondlist[i];

                        if (i == 0 && j != 0)
                        {
                            resultlist[j - 1] -= 1;
                        }
                    }


                }

                return new BigNumber(string.Join("", resultlist));
            }

            if (firstlist.Count < secondlist.Count)
            {

                var temp = firstlist;
                firstlist = secondlist;
                secondlist = temp;
                var resultlist = firstlist.ToArray();
                for (int i = secondlist.Count - 1, j = firstlist.Count - 1; i >= 0; i--, j--)
                {


                    if (secondlist[i] <= firstlist[j])
                    {
                        resultlist[j] = firstlist[j] - secondlist[i];
                    }

                    if (secondlist[i] > firstlist[j])
                    {
                        firstlist[j - 1] -= 1;
                        resultlist[j] = (firstlist[j] + 10) - secondlist[i];

                        if (i == 0 && j != 0)
                        {
                            resultlist[j - 1] -= 1;
                        }
                    }


                }
                resultlist[0] = -resultlist[0];
                return new BigNumber(string.Join("", resultlist));
            }

            return new BigNumber();
        }
    }
}
