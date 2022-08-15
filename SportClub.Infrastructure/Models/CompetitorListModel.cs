using SportClub.Domain.Enum;

namespace SportClub.Infrastructure.Models
{
    public class CompetitorListModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public Gender Gender { get; set; }
        public Degree? Degree { get; set; }
        public bool Is_Paid { get; set; }
        public DateTime MedicalExaminationExpiryDate { get; set; }
        public string? GroupName { get; set; }
    }
}
