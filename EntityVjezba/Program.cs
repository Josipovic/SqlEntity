using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityVjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomobilContext db = new AutomobilContext();

            foreach (var a in db.Automobili) {

                Console.WriteLine(a.Cijena + " " + a.Marka + " " + a.Model + " " +a.Godiste + " " + a.PredjeniKilometri);
            }

            Console.Read();
        }
    }
}
