using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteRemote concreteRemote = new ConcreteRemote();
            PandaTV pandaTV = new PandaTV();
            concreteRemote.SetTV(pandaTV);
            concreteRemote.SetChannel();
            ChangHongTV changHongTV = new ChangHongTV();
            concreteRemote.SetTV(changHongTV);
            concreteRemote.SetChannel();

            Console.ReadKey();
        }
    }
}
