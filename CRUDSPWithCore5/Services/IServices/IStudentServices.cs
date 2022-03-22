using CRUDWithSPDemo.Models;
using System.Collections.Generic;

namespace CRUDSPWithCore5.Services.IServices
{
    public interface IStudentServices
    {
        IEnumerable<StudentMaster> GetAllStudent();
    }
}
