using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Vote
{
    static class Extension
    {
        private static IDictionary<string, bool> ToBooleans = new Dictionary<string, bool>
        {
            ["yes"] = true,
            ["yeah"] = true,
            ["yah"] = true,
            ["y"] = true,
            ["1"] = true,
            ["ok"] = true,

            ["no"] = false,
            ["nah"] = false,
            ["n"] = false,
            ["0"] = false
        };


        public static bool ToBoolCheck(this string str)
        {
            try
            {
                return ToBooleans[str];
            }
            catch (Exception ex)
            {
                ex.Message.PressAnyKeyToProcced();
                return false;
            }
            return true;
        }
        public static bool ToBool(this string str)
        {
            return ToBooleans[str];
        }

        public static void PressAnyKeyToProcced(this string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Press any key to procced");
            Console.ReadKey();
        }

    }
}
