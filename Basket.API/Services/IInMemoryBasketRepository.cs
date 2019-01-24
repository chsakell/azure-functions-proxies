using Basket.API.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Basket.API.Services
{
    public interface  IInMemoryBasketRepository
    {
        Task<CustomerBasket> UpdateBasketAsync(CustomerBasket basket);
        Task<CustomerBasket> GetBasketAsync(Guid id);
        Task DeleteBasketAsync(Guid id);
    }
}
