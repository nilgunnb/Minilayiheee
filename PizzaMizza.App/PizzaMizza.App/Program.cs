using PizzaMizza.Core.Enums;

foreach (var item in Enum.GetValues(typeof(PizzaSize)))
{
    Console.WriteLine($"{(int)item}. {item}");
}

int.TryParse(Console.ReadLine(), out int index);

PizzaSize pizzaSize = (PizzaSize)index;

Console.WriteLine(pizzaSize);