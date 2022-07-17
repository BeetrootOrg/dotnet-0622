namespace ConsoleApp
{

    class Program
    {
        static void Main()
        {

            var bn1 = new BigNumber("18723648917264912649789689");
            var bn2 = new BigNumber("890237509283598124981724981");

            var bn3 = bn1 + bn2;
            var bn4 = bn1 - bn2;

            Console.WriteLine(bn4._number);

        }

        public static List<int> ToIntList(string num)
        {
            var f = num.ToArray();
            List<int> first = new List<int>();

            for (int i = 0; i < f.Length; i++)
            {
                int temp = 0;
                int.TryParse(f[i].ToString(), out temp);
                first.Add(temp);
            }
            return first;
        }
    }

}


