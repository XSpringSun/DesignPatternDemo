using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class SimplePizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = SimplePizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }

    public static class SimplePizzaFactory
    {
        public static Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type == "cheese")
            {
                //pizza = new CheesePizza();
            }
            else if (type == "viggie")
            {
                pizza = new VeggiePizza();
            }
            return pizza;
        }
    }
    public abstract class Pizza
    {
        public String Name;
        Veggie veggie;
        Cheese cheese;
        //准备
        public abstract void Prepare();
        //烘烤
        public void Bake() { }
        //切片
        public void Cut() { }
        //装盒
        public void Box() { }
    }

    //奶酪披萨
    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory IngredientFactory;
        public CheesePizza(PizzaIngredientFactory IngredientFactory) {
            this.IngredientFactory = IngredientFactory;
        }
        public override void Prepare()
        {
            IngredientFactory.CreateCheese();
        }
    }

    public interface PizzaIngredientFactory {
        public Veggie CreateVeggie();
        public Cheese CreateCheese();
    }

    public class CNHPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new CHNCheese();
        }

        public Veggie CreateVeggie()
        {
            return new CHNVeggie();
        }
    }

    public abstract class Veggie
    {
    }
    public class USVeggie : Veggie { 
    }
    public class CHNVeggie : Veggie { 
    }

    public abstract class Cheese
    {
    }
    public class USCheese : Cheese
    {
    }
    public class CHNCheese : Cheese
    {
    }
    
    //素食披萨
    public class VeggiePizza : Pizza
    {
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
