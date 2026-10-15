using System.ComponentModel.DataAnnotations;

namespace ModelValidationsExample.Model
{
    public class Person
    {
        [Required(ErrorMessage = "Person Name can not be null or empty.")]
        public string? PersonName {get; set;}
        public string? Email {get; set;}
        public string? Phone {get; set;}
        public string? Password {get; set;}
        public string? ConfirmPassword {get; set;}
        public string? Price {get; set;}

        public override string ToString()
        {
            return @$"Person object - Person Name: {PersonName},
            Email: {Email}, Phone Number: {Phone}, Password: {Password},
            Password Confirmation: {ConfirmPassword}, Price: {Price}";
        }

    }
}