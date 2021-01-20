using System;
using System.Collections.Generic;
using System.Text;
using CompanyEmployees.Models;

namespace Contracts
{
    public interface ICompanyRepository :IRepositoryBase<Company>
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
        Company GetCompany(Guid companyId, bool trackChanges);
    }
}
