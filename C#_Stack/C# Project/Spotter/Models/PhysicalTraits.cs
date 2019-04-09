using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Spotter.Models
{
    public class PhysicalTraits
    {
        [Key]
        public int PhysicalTraitsId {get;set;}

        public int UserId {get;set;}

        [Required(ErrorMessage="*Required")]
        public string Height {get;set;}
        
        
        
        [Required(ErrorMessage="*Required")]
        public string Weight {get;set;}



        [Required(ErrorMessage="*Required")]
        public int SquatMax {get;set;}
        
        
        
        [Required(ErrorMessage="*Required")]
        public int BenchMax {get;set;}



        [Required(ErrorMessage="*Required")]
        public int Age {get;set;}



        [Required(ErrorMessage="*Required")]
        public string Gender {get;set;}



        [Required(ErrorMessage="*Required")]
        public string WorkoutStyle {get;set;}



        [Required(ErrorMessage="*Required")]
        public string WorkoutSchedule {get;set;}
    }
}