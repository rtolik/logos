using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Computer c1 = new Computer("Asus", "i7-k5500", true, 999);
            Console.WriteLine(c1);
            c1.display.widh = 1920;
            c1.display.heigh = 1080;
            Console.WriteLine(c1.display.Resolution);*/
            LivingPlace flat1 = new LivingPlace(63.5f, 4, "Somewhere", 12570);
            Console.WriteLine("Flat:");
            Console.WriteLine(flat1);
            Villa vill1 = new Villa(4, true, 65.5f, 8, "Italia", 102425);
            Console.WriteLine("Villa:");
            Console.WriteLine(vill1);
            HotelRoom room1 = new HotelRoom(2, 500, 32.4f, 3, "Somwhere", 45670);
            Console.WriteLine("Hotel room:");
            Console.WriteLine(room1);
        }
    }
}
