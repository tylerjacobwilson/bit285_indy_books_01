using System;
using System.ComponentModel.DataAnnotations;
namespace IndyBooks.ViewModels
{
    public class SearchVM
    {
        [Display(Name = "Title to Find: ")]
        public String Title { get; set; }

        //TODO: Add properties and Display annotation needed for searching


        [Display(Name = "Half-Price Sale: ")]
        public Boolean HalfPriceSale { get; set; }
    }
}
