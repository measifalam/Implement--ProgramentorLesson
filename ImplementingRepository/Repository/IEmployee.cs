using ImplementingRepository.Models;

namespace ImplementingRepository.Repository
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
    }
}
