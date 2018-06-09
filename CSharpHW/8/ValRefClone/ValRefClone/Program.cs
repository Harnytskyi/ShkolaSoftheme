using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValRefClone
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = a;

            Console.WriteLine("{0} {1}", a, b);
            b = 8;
            Console.WriteLine("{0} {1}", a, b);

            User user1 = new User("Joe", 44, "Norway");
            User user2 = user1;

            Console.WriteLine("User1: {0}, {1}, {2}", user1.Name, user1.Age, user1.Country);
            Console.WriteLine("User2: {0}, {1}, {2}", user2.Name, user2.Age, user2.Country);

            user2.Country = "Australia";

            Console.WriteLine("User1: {0}, {1}, {2}", user1.Name, user1.Age, user1.Country);
            Console.WriteLine("User2: {0}, {1}, {2}", user2.Name, user2.Age, user2.Country);

            Console.ReadLine();
        }
    }
}
