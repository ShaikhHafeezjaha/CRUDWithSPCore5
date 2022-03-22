using CRUDSPWithCore5.Services.IServices;
using CRUDWithSP.Entites;
using CRUDWithSPDemo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CRUDSPWithCore5.Services
{
    public class StudentServices : IStudentServices
    {
        protected DataDbContext Context;
        public StudentServices(DataDbContext context)
        {
            Context = context;
        }

        public IEnumerable<StudentMaster> GetAllStudent()
        {
            return Context.StudentMasters.FromSqlRaw<StudentMaster>("EXEC [dbo].[GetAllStudent]").ToList();
        }
    }
}
