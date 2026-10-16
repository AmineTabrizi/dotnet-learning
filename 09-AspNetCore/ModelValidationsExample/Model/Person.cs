using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ModelValidationsExample.Model
{
    public class Person
    {
        [Required(ErrorMessage = "{0} can not be null or empty.")]
        [Display(Name = "Person Name")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "{0} Should be between {2} and {1} characters long.")]
        [RegularExpression("^[A-Za-z .]*$", ErrorMessage = "{0} Should contain only alphabet & dot & space!")]
        public string? PersonName {get; set;}
        [EmailAddress(ErrorMessage = "{0} should be a proper email address.")]
        [Required(ErrorMessage = "{0} can not be blank.")]
        public string? Email {get; set;}
        [Phone(ErrorMessage = "{0} should contain 10 digits!")]
        [ValidateNever]
        public string? Phone {get; set;}
        [Required(ErrorMessage = "{0} can not be blank.")]
        public string? Password {get; set;}
        [Required(ErrorMessage = "{0} can not be blank.")]
        [Compare("Password", ErrorMessage = "{0} & {1} don't match!")]
        [Display(Name = "Re-enter Password")]
        public string? ConfirmPassword {get; set;}

        [Range(0, 999.99, ErrorMessage = "{0} Should be between ${1} & ${2}.")]
        public double? Price {get; set;}
        public override string ToString()
        {
            return @$"Person object - Person Name: {PersonName},
            Email: {Email}, Phone Number: {Phone}, Password: {Password},
            Password Confirmation: {ConfirmPassword}, Price: {Price}";
        }

    }
}