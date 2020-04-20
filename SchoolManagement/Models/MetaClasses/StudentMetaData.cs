using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models
{
    public class StudentMetaData
    {
        
        [Display(Name ="Last Name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Display(Name = "Date of Enrollment")]
        [Required]
        public Nullable<System.DateTime> EnrollmentDate { get; set; }
        [Display(Name = "Middle Name ")]
        [Required]
        [StringLength(50)]
        public string MiddleName { get; set; }
    }
    [MetadataType (typeof (StudentMetaData))]
    public partial class Student 
    {
        
    }
}