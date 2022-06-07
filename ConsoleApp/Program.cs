           //First Task
           byte operand3  = 255;

           short operand4 =102;

           int operand5  = 5;

           long operand6  = 808;

           bool operand7 = true;

           float operand8 = 3_000.5F;

           decimal myMoney = 2.1m;

           System.Console.WriteLine(operand3  +  operand3 );
           System.Console.WriteLine(operand4 * operand4);
           System.Console.WriteLine( !operand7 );

           System.Console.WriteLine(myMoney + 400.75M);


//Second Task   All Math Operations 

            double operand1 = 9;
            double operand2 = 12;


            double sumofMax = Math.Max(operand1, operand2);   // Find Max of Number

            double sumofAbs = Math.Abs(operand1) * Math.Sin(operand1);   //Find ABS and Sinus

            double pi = 2 * Math.PI * operand1; // Find Number Of Pi

            double stepen = (-6 * Math.Pow(operand1, 3) ) + ( 5 * Math.Pow(operand1, 2) ) - (10 * operand1 + 15);  //Find Stepen of Numbers


            Console.WriteLine("Результат Уровнения задание  1 ----> {0}", sumofMax);

            Console.WriteLine("Результат Уровнения задание  2 ---->  {0}", sumofAbs);

            Console.WriteLine("Результат Уровнения задание  3 ---->  {0}", pi);

            Console.WriteLine("Результат Уровнения задание  4 ---->  {0}", stepen);


//Extra Task --------------------------------
            int daysofyear = 365;

            DateTime date = DateTime.Now;

            Console.WriteLine("{0} days passed from New Year ", date.DayOfYear);
            Console.WriteLine("{0} days left to New Year",  daysofyear - date.DayOfYear);
