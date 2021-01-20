using CompanyEmployees.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IEmployeeRepository : IRepositoryBase<Employee>
    {
        IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChanges);
        Employee GetEmployee(Guid companyId, Guid id, bool trackChanges);

    }
}
