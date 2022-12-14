using System.ComponentModel.DataAnnotations;

namespace ShopOnline
{
    public class DeliveryAddress
    {
        public int ID {get; set;}

        [Required, MinLength(2, ErrorMessage = "Please use a Name bigger than 3 letters.")]
        public string Name {get; set;}

        [Required, MinLength(5, ErrorMessage = "Please use an Address bigger than 5 letters.")]
        public string FirstLine {get; set;}
        public string SecondLine {get; set;}

        [Required, MinLength(3, ErrorMessage = "Please use a City bigger than 3 letters.")]
        public string City {get; set;}

        [Required, MinLength(3, ErrorMessage = "Please use a Region bigger than 3 letters.")]
        public string Region {get; set;}

        [Required, RegularExpression(@"^([0-9]{5})$", ErrorMessage = "Please use a valid Postal Code with five numbers.")]
        public string PostalCode {get; set;}
    }
}