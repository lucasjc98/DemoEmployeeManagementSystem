using System.ComponentModel.DataAnnotations;

namespace DEMS.BaseLibrary.DTOs
{
    public class AccountBaseDTO
    {
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Required]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string? Password { get; set; }
    }
}
