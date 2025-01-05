using System;

namespace DesignPattern.Behavioral.TemplateMethodPattern.ExampleUsage
{
    public abstract class MealPreparation
    {
        public void PrepareMeal()
        {
            PrepareIngredients();
            CookOrPrepare();
            Serve();
            Hook();
        }

        protected abstract void PrepareIngredients();

        protected abstract void CookOrPrepare();
        protected virtual void Serve()
        {
            Console.WriteLine("Meal is served with standard plating.");
        }

        protected virtual void Hook()
        {
        }
    }
}