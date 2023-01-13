using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeoProfs.Models
{
    public class Users
    {
        public int ID { get; set; }
        public int team_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int position { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}
