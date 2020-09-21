using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employee;

        public MockEmployeeRepository()
        {
            _employee = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Atm", Email= "Atm@gmail.com", Department =Dept.HR},
                new Employee(){Id = 2, Name = "Abdul Ahad", Email= "Abdul@gmail.com", Department =Dept.SE },
                new Employee(){Id = 3, Name = "Talha", Email= "talha@gmail.com", Department = Dept.IT}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employee;
        }

        public Employee GetEmployee(int id)
        {
            return _employee.FirstOrDefault(x => x.Id == id);
        }
    }
}
