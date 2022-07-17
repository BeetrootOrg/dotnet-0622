using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.InternetShop
{
    internal class Emploee : Client
    {
        private int EmploeeId { get; init; }
        private decimal EmploeeSalary { get; set; }
        private DateTime WorkingHours { get; set; }
    }
}
