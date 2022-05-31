using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace GrowthModels
{
    public class Goals
    {
        [Key]
        [Required]
        public string GoalName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Habit1 { get; set; }
        [Required]
        public string Habit2 { get; set; }
        [Required]
        public string Habit3 { get; set; }

    }
}
