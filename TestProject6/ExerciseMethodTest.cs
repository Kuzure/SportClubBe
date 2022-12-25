using Moq;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;

namespace TestProject6;

public class ExerciseMethodTest
{
    [Fact]
    public void SaveTest()
    {
        var repo = new Mock<IExerciseRepository>();
        var exercise = new Exercise()
        {
            Id = Guid.NewGuid(),
            Description = "Description",
            Name = "Name",
            GroupExercises = new List<GroupExercise>(),
        };
        var x = repo.Object;
        x.Save(exercise);
        
        repo.Verify(r => r.Save(exercise), Times.Once);
    }
    [Fact]
    public void UpdateTest()
    {
        var repo = new Mock<IExerciseRepository>();
        var exercise = new Exercise()
        {
            Id = Guid.NewGuid(),
            Description = "Description",
            Name = "Name",
            GroupExercises = new List<GroupExercise>(),
        };
        var x = repo.Object;
        x.Update(exercise);
        
        repo.Verify(r => r.Update(exercise), Times.Once);
    }
    [Fact]
    public void GetAllTest()
    {
        var repo = new Mock<IExerciseRepository>();
        var x = repo.Object;
        x.GetAll();
        
        repo.Verify(r => r.GetAll(), Times.Once);
    }
    [Fact]
    public void GetByIdTest()
    {
        var repo = new Mock<IExerciseRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.GetById(guid);
        
        repo.Verify(r => r.GetById(guid), Times.Once);
    }
    [Fact]
    public void GetAllWithNoGroupTest()
    {
        var repo = new Mock<IExerciseRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.GetAllWithNoGroup(guid);
        
        repo.Verify(r => r.GetAllWithNoGroup(guid), Times.Once);
    }
    [Fact]
    public void DeleteTest()
    {
        var repo = new Mock<IExerciseRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.Delete(guid);
        
        repo.Verify(r => r.Delete(guid), Times.Once);
    }
    [Fact]
    public void GetPageableTest()
    {
        var repo = new Mock<IExerciseRepository>();
        var x = repo.Object;
        x.GetPageable(1,5);
        
        repo.Verify(r => r.GetPageable(1,5), Times.Once);
    }
}