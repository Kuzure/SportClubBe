using System.ComponentModel;

namespace SportClub.Domain.Enum
{
    public enum Gender
    {
        [Description("Mężczyzna")]
        Male = 0,
        [Description("Kobieta")]
        Female = 1,
    }
}
