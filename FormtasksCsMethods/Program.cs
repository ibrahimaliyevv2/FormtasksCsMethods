using System;

namespace FormtasksCsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task Additions

            #region Form-Task1 Addition
            //int result = CountOfChar("Fazail", 'a');
            //Console.WriteLine($"Symbol is used {result} times.");
            #endregion

            #region Form-Task2 Addition
            //Console.WriteLine(ReverseOfWord("salam"));
            #endregion

            #region Form-Task3 Addition
            //int result = FindSolution(58);
            //Console.WriteLine(result);
            #endregion

            #region Form-Task4 Addition
            //int[] numbers = {5, 10, 3, 4, 17 };
            //int result = IndexOfMinum(numbers);
            //Console.WriteLine(result);
            #endregion

            #region Form-Task5 Addition
            //int[] numbers = { 5, 10, 3, 4, 17 };
            //int result = ProductMaxMin(numbers);
            //Console.WriteLine(result);
            #endregion

            #region Form-Task6 Addition
            //Console.WriteLine(CountVowel("bizimlesiniz"));
            #endregion

            #region Form-Task7 Addition
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(MaximumOf3(num1, num2, num3));
            #endregion

            #region Form-Task8 Addition
            //int price1 = Convert.ToInt32(Console.ReadLine());
            //int price2 = Convert.ToInt32(Console.ReadLine());
            //int price3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(PriceOfProducts(price1, price2, price3));
            #endregion

            #endregion

        }

        #region Methods
        //Form-Task1: Gonderilen char-in bir sozde nece defe istifade olundugunu yazin
        static int CountOfChar(string text, char ch)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (ch == text[i])
                {
                    count++;
                }
            }
            return count;
        }


        //Form-Task2: Verilen sozu tersine ceviren metod yazin(meselen: salam --> malas)
        static string ReverseOfWord(string text)
        {
            string reversedText = " ";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            return reversedText;

        }


        //Form-Task3: Ededin reqemlerinin hasili ile ceminin ferqini tapan metod yazin
        static int FindSolution(int num)
        {
            int i = 0;
            int sum = 0;
            int product = 1;

            while (i < num)
            {
                product *= num % 10;
                sum += num % 10;
                num /= 10;
            }
            int difference = product - sum;
            return difference;
        }


        //Form-Task4: Massivdeki en kicik ededin indeksini tapan metod yazin
        static int IndexOfMinum(int[] numbers)
        {
            int min = numbers[0];
            int minIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                    minIndex = i;
                }
                
            }
            return minIndex;
        }

        //Form-Task5: Massivde minimum ededle maksimum ededin hasilini tapan metod yazin
        static int ProductMaxMin(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
                if(max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max * min;
        }

        //Form-Task6: Verilmis sozde sait herflerin sayini tapan metod yazin
        static int CountVowel(string word)
        {
            char[] vowels = { 'a', 'e', 'o', 'u', 'i'};
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (word[i] == vowels[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        
        //Form-Task7: Gonderilmis 3 ededden en boyuyunu tapan metod
        static int MaximumOf3(int num1, int num2, int num3)
        {
            if(num1>num2 && num1 > num3)
            {
                return num1;
            }

            else if(num2 > num1 && num2 > num3)
            {
                return num2;
            }

            else
            {
                return num3;
            }
        }
        
        //Form-Task8: Supermarketde bele bir aksiya kecirilir: "Istenilen iki mal alana ucuncu pulsuz verilir."
        //"Ancaq secilmis 3 maldan iki en bahalisinin qiymeti odenilir."
        //Alinacaq uc mehsulun qiymeti verilmisdirse odenilecek meblegi hesablayan metod yazin.

        static int PriceOfProducts(int price1, int price2, int price3)
        {
            if(price1<price2 && price1 < price3)
            {
                return price2 + price3;
            }

            else if(price2<price1 && price2 < price3)
            {
                return price1 + price3;
            }

            else
            {
                return price1 + price2;
            }
        }
        #endregion
    }
}
