using FinalProject.Core.Models;
using FinalProject.Core.IRepositories;
using FinalProject.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject;

namespace FinalProject.Core.IRepositories
{
    public interface IAdminRepository : IBaseRepository<Admin>
    {
        public Task<Admin> AdminLogin(string email , string password);
    }
}
