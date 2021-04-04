using System;
using System.ComponentModel.DataAnnotations; //Import data annotations
using Microsoft.AspNetCore.Mvc; //Fixes [Remote] not found
namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Date is required.")]
        [Remote("CheckDate", "Validation")] //ValidateController
        public DateTime? Date { get; set; }
        [Required(ErrorMessage = "lowest temperature is required.")]
        [Range(-200, 200, ErrorMessage = "The lowest temperature needs to be between -200 and 200.")]
        public double? Low { get; set; }
        [Required(ErrorMessage = "highest temperature is required")]
        [Range(-200, 200, ErrorMessage = "The highest temperature needs to be between -200 and 200.")]
        public double? High { get; set; }
    }
}
