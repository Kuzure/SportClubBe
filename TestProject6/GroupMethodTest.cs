using Moq;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;

namespace TestProject6;

public class GroupMethodTest
{
    [Fact]
    public void SaveTest()
    {
        var repo = new Mock<IGroupRepository>();
        var group = new Group()
        {
            Id = Guid.NewGuid(),
            Name = "Group",
            
        };
        var x = repo.Object;
        x.Save(group);
        
        repo.Verify(r => r.Save(group), Times.Once);
    }
    [Fact]
    public void UpdateTest()
    {
        var repo = new Mock<IGroupRepository>();
        var group = new Group()
        {
            Id = Guid.NewGuid(),
            Name = "Group",
            
        };
        var x = repo.Object;
        x.Update(group);
        
        repo.Verify(r => r.Update(group), Times.Once);
    }
    [Fact]
    public void GetAllTest()
    {
        var repo = new Mock<IGroupRepository>();
        var x = repo.Object;
        x.GetAll();
        
        repo.Verify(r => r.GetAll(), Times.Once);
    }
    [Fact]
    public void GetByIdTest()
    {
        var repo = new Mock<IGroupRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.GetById(guid);
        
        repo.Verify(r => r.GetById(guid), Times.Once);
    }
    [Fact]
    public void DeleteTest()
    {
        var repo = new Mock<IGroupRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.Delete(guid);
        
        repo.Verify(r => r.Delete(guid), Times.Once);
    }
    [Fact]
    public void GetPageableTest()
    {
        var repo = new Mock<IGroupRepository>();
        var x = repo.Object;
        x.GetPageable(1,5);
        
        repo.Verify(r => r.GetPageable(1,5), Times.Once);
    }
}