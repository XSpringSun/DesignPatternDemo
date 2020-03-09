using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza= CreatePizza(type);
            

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }

    public class USSytlePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type == "cheese")
            {
                pizza = new USStyleCheesePizza();
            }
            else if (type == "viggie")
            {
                pizza = new USStyleVeggiePizza();
            }
            return pizza;
        }
    }

    public class CHNSytlePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            CNHPizzaIngredientFactory ingredientFactory = new CNHPizzaIngredientFactory();
            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
            }
            else if (type == "viggie")
            {
                //pizza = new VeggiePizza(ingredientFactory);
            }
            return pizza;
        }
    }

    //US奶酪披萨
    public class USStyleCheesePizza : Pizza
    {
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
    //US素食披萨
    public class USStyleVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }

    //CHN奶酪披萨
    public class CHNStyleCheesePizza : Pizza
    {
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
    //CHN素食披萨
    public class CHNStyleVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
