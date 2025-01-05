using System;

namespace DesignPattern.Behavioral.TemplateMethodPattern.ExampleUsage
{
    public class PizzaPreparation : MealPreparation
    {
        protected override void PrepareIngredients()
        {
            Console.WriteLine("Preparing pizza dough, sauce, and toppings.");
        }

        protected override void CookOrPrepare()
        {
            Console.WriteLine("Baking pizza in the oven.");
        }

        protected override void Serve()
        {
            Console.WriteLine("Serving pizza on a wooden tray.");
        }
    }
    
    public class SaladPreparation : MealPreparation
    {
        protected override void PrepareIngredients()
        {
            Console.WriteLine("Washing and chopping vegetables.");
        }

        protected override void CookOrPrepare()
        {
            Console.WriteLine("Mixing vegetables with dressing.");
        }

        protected override void Hook()
        {
            Console.WriteLine("Adding croutons and cheese as toppings.");
        }
    }

    public class DessertPreparation : MealPreparation
    {
        protected override void PrepareIngredients()
        {
            Console.WriteLine("Preparing flour, sugar, and other dessert ingredients.");
        }

        protected override void CookOrPrepare()
        {
            Console.WriteLine("Baking dessert in the oven.");
        }

        protected override void Serve()
        {
            Console.WriteLine("Serving dessert on a fancy plate.");
        }
    }
}