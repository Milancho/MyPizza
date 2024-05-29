namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<PizzaExample[]> GetPizzasAsync()
    {
        // Call your data access technology here
        List<PizzaExample> pizzas = new()
        {
            new PizzaExample
            {
                Name = "Margherita",
                Description = "The classic. Fresh tomatoes, fresh mozzarella, fresh basil",
                Price = 5.99m,
                Vegetarian = false,
                Vegan = false
            },
            new PizzaExample
            {
                Name = "Pepperoni",
                Description = "Classic pepperoni pizza",
                Price = 7.99m,
                Vegetarian = false,
                Vegan = false
            }
        };

        return Task.FromResult(pizzas.ToArray());
    }
}