using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDSPWithCore5.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string StudName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DOB { get; set; }
    }
}
