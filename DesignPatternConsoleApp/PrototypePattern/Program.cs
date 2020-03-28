using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster wellKnowMonster = new WellKnowMonster();
            Monster dynamicGeneratedMonster = new DynamicGeneratedMonster();

            MonsterRegistry monsterRegistry = new MonsterRegistry();
            monsterRegistry.RegisterMonster("wellKnowMonster",wellKnowMonster);
            monsterRegistry.RegisterMonster("dynamicGeneratedMonster",dynamicGeneratedMonster);

            Console.WriteLine($"wellKnowMonster1:{monsterRegistry.GetMonster("wellKnowMonster").GetHashCode()}");
            Console.WriteLine($"wellKnowMonster2:{monsterRegistry.GetMonster("wellKnowMonster").GetHashCode()}");
            Console.WriteLine($"dynamicGeneratedMonster1:{monsterRegistry.GetMonster("dynamicGeneratedMonster").GetHashCode()}");
            Console.WriteLine($"dynamicGeneratedMonster2:{monsterRegistry.GetMonster("dynamicGeneratedMonster").GetHashCode()}");
            Console.ReadKey();
        }
    }
}
