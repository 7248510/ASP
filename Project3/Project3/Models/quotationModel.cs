using System.ComponentModel.DataAnnotations;

namespace Project3.Models
{
    public class quotationModel
    {
        [Required(ErrorMessage = "Please enter a sale price.")]
        [Range(0, int.MaxValue, ErrorMessage = "The sales price is not greater than zero.")]
        public decimal? subTotal { get; set; }
        //End Sub total
        [Required(ErrorMessage = "Please enter a discount percent.")]
        [Range(0, 100.0, ErrorMessage = "The percent rate needs to be between 0 and 100%")]
        public decimal? discountPercent { get; set; }
        public decimal? calculateSales()
        {
            decimal? discountAmount = subTotal * (discountPercent / 100);
            return discountAmount;
        }
        public decimal? discountamount(decimal? passMe)
        {
            decimal? calc = subTotal - passMe;
            decimal? total = calc; //-subTotal 
            return total;
        }
    }
}
