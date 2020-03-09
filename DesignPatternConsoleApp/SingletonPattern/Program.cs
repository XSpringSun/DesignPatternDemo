using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                TestSingleton();
            }
            Console.ReadKey();
        }

        public static void TestSingleton()
        {
            Task.Factory.StartNew(new Action(() =>
            {
                var hc = ObjectClass.GetSingletone().GetHashCode();
                Console.WriteLine(hc);
            }));
        }
    }
}
