using FinalProject.Core.IRepositories;
using FinalProject.Core.Models;
using FinalProject.EF.Configuration;
using FinalProject.Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using FinalProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.EF.RepositoriesImplementation
{
    public class CollegeRepositoryImp : BaseRepositoryImp<College>, ICollegeRepository
    {
        public CollegeRepositoryImp(ApplicationDbContext context) : base(context)
        {

        }


    }
}