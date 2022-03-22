using CRUDWithSPDemo.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUDSPWithCore5.Models
{
    public class CityMaster
    {
        [Key]
        public int Id { get; set; }
        public string CityName { get; set; }

        public ICollection<StudentMaster> StudentMasters { get; set; }
    }
}
