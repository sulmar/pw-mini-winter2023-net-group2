using Domain.Model;

namespace Domain.Abstractions
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        Customer GetById(int id);
    }
    
}