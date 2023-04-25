using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.App.Services.Interfaces
{
    public interface IPizzaService
    {
        public Task CreateAsync();

        public Task UpdateAsync();

        public Task DeleteAsync();

        public Task GetAsync();

        public Task GetAllAsync();



    }
}
