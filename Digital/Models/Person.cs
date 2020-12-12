using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Digital.Services;
using Digital.Utilities.Validations;

namespace Digital.Models
{
    public class Person : AbstractValidatableObject
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Не указано Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Не указана Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Не указана Дата")]
        public string DateOfBirth { get; set; }

        public ICollection<Resume> Resumes { get; set; }

        public override async Task<IEnumerable<ValidationResult>> ValidateAsync(ValidationContext validationContext,
       CancellationToken cancellation)
        {
            var errors = new List<ValidationResult>();

            if (FirstName.Length < 3)
                errors.Add(new ValidationResult("None length cannot be less than 3", new[] { nameof(FirstName) }));

            if (FirstName.Length > 50)
                errors.Add(new ValidationResult($"Name: {FirstName} not allowed to work. Max name length is 30 ", new[] { nameof(FirstName) }));


            // Database call through service for validation
            var dbContext = new PersonServiceImpl();
            bool isExists = false;
            try
            {
                isExists = await dbContext.IsPersonExist(FirstName);
            }
            catch
            {
                isExists = false;
            }
            if (isExists)
            {
                errors.Add(new ValidationResult("Genre exist", new[] { nameof(Person) }));
            }


            return errors;
        }
        public Person()
        {
            Resumes = new List<Resume>();
        }
     
    }
}





