using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using RazorPagesTest.Models;

namespace RazorPagesTest.Pages
{
    public class FutureValueModel : PageModel
    {
        [Display(Name="Monthly Investment")]
        public decimal MonthlyInvestment { get; set; }
         
        [Display(Name="Yearly Interest Rate")]
        public decimal YearlyInterestRate { get; set; }

        [Display(Name="Number of years")]
        public int Years { get; set; }

        public void OnGet()
        {
            ViewData["FV"] = 0;
        }

        public void OnPost(FutureValue model)
        {
            ViewData["FV"] = model.CalculateFutureValue();
        }
    }
}