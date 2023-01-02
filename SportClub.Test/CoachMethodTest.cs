using Moq;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;

namespace TestProject6;

public class CoachMethodTest
{ 
    [Fact]
    public void SaveTest()
    {
        var repo = new Mock<ICoachRepository>();
        var coaches = new Coach
        {
            CoachClass = 1,
            IdentityId = Guid.NewGuid(),
            Id = Guid.NewGuid()
        };
        var list = new List<CoachGroup>();
        coaches.CoachGroups = list;
        var x = repo.Object;
        x.Save(coaches);
        
        repo.Verify(r => r.Save(coaches), Times.Once);
    }
    [Fact]
    public void UpdateTest()
    {
        var repo = new Mock<ICoachRepository>();
        var coaches = new Coach
        {
            CoachClass = 1,
            IdentityId = Guid.NewGuid(),
            Id = Guid.NewGuid()
        };
        var list = new List<CoachGroup>();
        coaches.CoachGroups = list;
        var x = repo.Object;
        x.Update(coaches);
        
        repo.Verify(r => r.Update(coaches), Times.Once);
    }
    [Fact]
    public void GetAllTest()
    {
        var repo = new Mock<ICoachRepository>();
        var x = repo.Object;
        x.GetAll();
        
        repo.Verify(r => r.GetAll(), Times.Once);
    }
    [Fact]
    public void GetByIdTest()
    {
        var repo = new Mock<ICoachRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.GetById(guid);
        
        repo.Verify(r => r.GetById(guid), Times.Once);
    }
    [Fact]
    public void GetAllWithNoGroupTest()
    {
        var repo = new Mock<ICoachRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.GetAllWithNoGroup(guid);
        
        repo.Verify(r => r.GetAllWithNoGroup(guid), Times.Once);
    }
    [Fact]
    public void GetCoachByGroupIdTest()
    {
        var repo = new Mock<ICoachRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.GetCoachByGroupId(guid);
        
        repo.Verify(r => r.GetCoachByGroupId(guid), Times.Once);
    }
    [Fact]
    public void DeleteTest()
    {
        var repo = new Mock<ICoachRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.Delete(guid);
        
        repo.Verify(r => r.Delete(guid), Times.Once);
    }
    [Fact]
    public void GetPageableTest()
    {
        var repo = new Mock<ICompetitorRepository>();
        var x = repo.Object;
        x.GetPageable(1,5);
        
        repo.Verify(r => r.GetPageable(1,5), Times.Once);
    }
}