using SportClub.Domain.Enum;

namespace SportClub.Infrastructure.Models
{
    public class CompetitorListModel
    {
        public Guid? Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string? Gender { get; set; }
        public string? Degree { get; set; }
        public bool Is_Paid { get; set; }
        public DateTime MedicalExaminationExpiryDate { get; set; }
        public string? GroupName { get; set; }
        
        public Guid? GroupId { get; set; }
    }
}
