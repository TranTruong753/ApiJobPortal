﻿using Backend.Models;

namespace Backend.Interfaces
{
    public interface ICompanyRepository: IRepository<Company>
    {
        Task UpdateAsync(Company company);
    }
}
