﻿namespace SportClub.Domain.Entity
{
    public class Exercise : BaseEntity<Guid>
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        
        public int? Repetitions { get; set; }
        public ICollection<GroupExercise> GroupExercises { get; set; } = null!;
    }
}
