using ImplementingRepository.Models;

namespace ImplementingRepository.Repository
{
    public class EmployeeRepository :IEmployee
    {
        

        public List<Employee> GetAllEmployees()
        {
            return DataSource();
        }

        public Employee GetEmployeeById(int id)
        {
            return DataSource().Where(x=>x.Id==id).FirstOrDefault();
        }

        private List<Employee> DataSource()
        {
            return new List<Employee>
            {
                 new Employee { Id = 1,Name="Asif",Email="Male@123",Address="Master",Phone="1234"},
                new Employee { Id = 2,Name="Asifa",Email="Male@34",Address="Master",Phone="1234"},
                new Employee { Id = 3,Name="Areeb",Email="Male@345",Address="Master",Phone="1234"}
            };
        }
    }
}
