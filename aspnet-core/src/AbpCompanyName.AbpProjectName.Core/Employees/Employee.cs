using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AbpCompanyName.AbpProjectName.Employees
{
    [Table("Employees")]
    public class Employee:Entity<long>, IHasCreationTime
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumner { get; set; }
        public string Address { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsDeleted { get; set; }
        public string ZipCode { get; set; }

        public Employee()
        {
            CreationTime = DateTime.UtcNow;
        }

    }
}
