﻿using CompanyEmployees.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IEmployeeRepository : IRepositoryBase<Employee>
    {
    }
}
