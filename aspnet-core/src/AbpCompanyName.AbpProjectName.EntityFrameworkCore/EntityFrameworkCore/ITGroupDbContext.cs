using Abp.Zero.EntityFrameworkCore;
using AbpCompanyName.AbpProjectName.Authorization.Roles;
using AbpCompanyName.AbpProjectName.Authorization.Users;
using AbpCompanyName.AbpProjectName.Employees;
using AbpCompanyName.AbpProjectName.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpCompanyName.AbpProjectName.EntityFrameworkCore
{
    public  class ITGroupDbContext : AbpZeroDbContext<Tenant, Role, User, ITGroupDbContext>
    {
        public DbSet<Employee> Emploees { get; set; }
        public ITGroupDbContext(DbContextOptions<ITGroupDbContext> options)
            : base(options)
        {

        }
    }
}
