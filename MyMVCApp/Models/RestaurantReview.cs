﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVCApp.Models
{   
    public class RestaurantReview : IValidatableObject
    {
        public int Id { get; set; }

        [Range(1, 10)]
        [Required]
        public int Rating { get; set; }

        [StringLength(1024)]
        [Required]
        public string Body { get; set; }

        [Display(Name = "User name")]
        [DisplayFormat(NullDisplayText = "anonymous")]
        public string ReviewerName { get; set; }
        public int RestaurantId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Rating < 2 && ReviewerName.ToLower().StartsWith("jackie"))
            {
                yield return new ValidationResult("Sorry, Jackie, you can't do this");
            }
        }
    }
}