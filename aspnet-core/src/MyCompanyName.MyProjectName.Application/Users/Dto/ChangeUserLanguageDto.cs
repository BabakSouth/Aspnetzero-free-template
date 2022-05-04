using System.ComponentModel.DataAnnotations;

namespace MyCompanyName.MyProjectName.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}

