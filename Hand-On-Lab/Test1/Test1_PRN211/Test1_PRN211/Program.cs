using System;
using System.Collections.Generic;
using static System.Console;
namespace Test1_PRN211
{
    //Both the Lion and Tiger classes will
    //implement the IAnimal interface method
    public interface IAnimal
    {
        void AboutMe();
    }
    //Lion class
    public class Lion : IAnimal
    {
        public void AboutMe() => WriteLine("This is Lion");
    }
    //Tiger class
    public class Tiger : IAnimal
    {
        public void AboutMe() => WriteLine("This is Tiger");
    }

    //Both LionFactory and TigerFactory will use this
    public abstract class AnimalFactory
    {
        /*Factory method lets a class defer instantiation to subclasse
         The following method will create a Tiger on a Lion,
        but at this point it does not know whether it will get a Lion or a Tiger.
        It will be decided by the subclasses i.e.LionFactory or TigerFactory.
        So, the following method is acting like a factory (of creation).*/
        public abstract IAnimal CreateAnimal();
    }
    //LionFactory is used to create Lions
    public class LionFactory : AnimalFactory
    {
        //Creating a Lion
        public override IAnimal CreateAnimal() => new Lion();
    }
    //TigerFactory is used to create tigers
    public class TigerFactory : AnimalFactory
    {
        //Create a tiger
        public override IAnimal CreateAnimal() => new Tiger();
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Factory Method Pattern Demo ***\n");
            //Create a list AnimalFactory included TigerFactory and LionFactory
            List<AnimalFactory> animalFactoryList = new List<AnimalFactory>
            {
                new TigerFactory(), new LionFactory()
            };
            foreach (var animal in animalFactoryList)
            {
                animal.CreateAnimal().AboutMe();
            }
            ReadLine();
        }
    }
}

