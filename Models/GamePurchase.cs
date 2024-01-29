using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RelationsNaN.Models;

namespace RelationsNaN.Models
{
    public class GamePurchase
    {
        public int Id { get; set; }
        [ValidateNever]
        public Game Game { get; set; }
        [ValidateNever]
        public Purchase Purchase { get; set; }
    }
}
