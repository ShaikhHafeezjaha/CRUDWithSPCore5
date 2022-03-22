using CRUDSPWithCore5.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDWithSPDemo.Models
{
    public record StudentMaster
    {
        public int Id { get; set; }
        public string StudName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DOB { get; set; }

        [ForeignKey("CityMaster")]
        public int CityId { get; set; }
        public CityMaster CityMaster { get; set; }
    }
}
