using PizzaMizza.App.Services.Interfaces;
using PizzaMizza.Core.Enums;
using PizzaMizza.Core.Models.MinorModels;
using PizzaMizza.Data.Repositories.MinorRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.App.Services.Implementation
{
    public class PizzaService : IPizzaService
    {
        private readonly PizzaRepository _pizzaRepository = new PizzaRepository();
        public async Task CreateAsync()
        {
            PizzaModel pizza = new PizzaModel();

            Console.WriteLine("Please, add Name");

            pizza.Name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(pizza.Name))
            {
                Console.WriteLine("Please, add valid Name");

                pizza.Name = Console.ReadLine();
            }

            Console.WriteLine("Please, add Size");


            foreach (var item in Enum.GetValues(typeof(PizzaSize)))
            {
                Console.WriteLine($"{(int)item}. {item}");
            }

            try
            {
                int.TryParse(Console.ReadLine(), out int index);

                PizzaSize pizzaSize = (PizzaSize)index;

            }
            catch
            {
                Console.WriteLine("Please, select valid option");
            }

            Console.WriteLine("Please, add ingredients");

            foreach (var item in Enum.GetValues(typeof(PizzaIngredients)))
            {
                Console.WriteLine($"{(int)item}. {item}");
            }

            try
            {
                int.TryParse(Console.ReadLine(), out int index);

                PizzaIngredients pizzaIngredient = (PizzaIngredients)index;
            }
            catch
            {
                Console.WriteLine("Please, select valid option");
            }

            _pizzaRepository.CreateAsync(pizza);
        }

        public Task DeleteAsync()
        {
          
        }

        public Task GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
















