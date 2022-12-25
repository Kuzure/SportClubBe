using Moq;
using SportClub.Application.Interface;
using SportClub.Application.Repository;
using SportClub.Domain.Entity;

namespace TestProject6;

public class CoachGroupRepositoryMethodTest
{
    [Fact]
    public void SaveTest()
    {
        var repo = new Mock<ICoachGroupsRepository>();
        var coachGroup = new CoachGroup()
        {
            GroupId = Guid.NewGuid(),
            CoachId = Guid.NewGuid(),
            
        };
        var x = repo.Object;
        x.Save(coachGroup);
        
        repo.Verify(r => r.Save(coachGroup), Times.Once);
    }
    [Fact]
    public void UpdateTest()
    {
        var repo = new Mock<ICoachGroupsRepository>();
        var coachGroup = new CoachGroup()
        {
            GroupId = Guid.NewGuid(),
            CoachId = Guid.NewGuid(),
            
        };
        var x = repo.Object;
        x.Update(coachGroup);
        
        repo.Verify(r => r.Update(coachGroup), Times.Once);
    }
    [Fact]
    public void GetAllTest()
    {
        var repo = new Mock<ICoachGroupsRepository>();
        var x = repo.Object;
        x.GetAll();
        
        repo.Verify(r => r.GetAll(), Times.Once);
    }
    [Fact]
    public void GetByIdTest()
    {
        var repo = new Mock<ICoachGroupsRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.GetById(guid);
        
        repo.Verify(r => r.GetById(guid), Times.Once);
    }
    [Fact]
    public void DeleteTest()
    {
        var repo = new Mock<ICoachGroupsRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.Delete(guid);
        
        repo.Verify(r => r.Delete(guid), Times.Once);
    }
    [Fact]
    public void GetIfExistByGroupIdTest()
    {
        var repo = new Mock<ICoachGroupsRepository>();
        var x = repo.Object;
        var id = Guid.NewGuid();
        x.GetIfExistByGroupId(id);
        
        repo.Verify(r => r.GetIfExistByGroupId(id), Times.Once);
    }
}