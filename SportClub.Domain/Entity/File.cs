namespace SportClub.Domain.Entity
{
    public class File : BaseEntity<Guid>
    {
        public string FileName { get; set; } = null!;
        public string UploadPath { get; set; } = null!;
        public string PathFileName { get; set; } = null!;
        public Guid? GroupId { get; set; }
        public virtual Group Group { get; set; } =null!;

    }
}
