
using System;
using System.ComponentModel.DataAnnotations;
namespace MIDAS_Fitness.Models
{
    public class PersonalDetails
    {
        public int Id { get; set; }

        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required, DataType(DataType.Date)] public DateTime DateOfBirth { get; set; }
        [Required, EmailAddress] public string Email { get; set; }
        [Required] public string PasswordHash { get; set; }
        [Required] public string CellPhone { get; set; }
        [Required] public string Street { get; set; }
        [Required] public string City { get; set; }
        [Required] public string PostalCode { get; set; }
        [Required, DataType(DataType.Date)] public DateTime StartDate { get; set; }
        public bool OrganizePaymentInFacility { get; set; }
        public string ProfilePhotoPath { get; set; }
    }
}
