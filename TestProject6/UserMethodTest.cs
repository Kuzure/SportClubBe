using Moq;
using SportClub.Application.Interface;
using SportClub.Domain.Entity;

namespace TestProject6;

public class UserMethodTest
{
    [Fact]
    public void SaveTest()
    {
        var repo = new Mock<IUserRepository>();
        var user = new User()
        {
            Id = Guid.NewGuid(),
            Email = "www@wp.pl",
            Password = "zaq1123$",
            RoleId = Guid.NewGuid(),
        };
        var x = repo.Object;
        x.Save(user);
        
        repo.Verify(r => r.Save(user), Times.Once);
    }
    [Fact]
    public void UpdateTest()
    {
        var repo = new Mock<IUserRepository>();
        var user = new User()
        {
            Id = Guid.NewGuid(),
            Email = "www@wp.pl",
            Password = "zaq1123$",
            RoleId = Guid.NewGuid(),
        };

        var x = repo.Object;
        x.Update(user);
        
        repo.Verify(r => r.Update(user), Times.Once);
    }
    [Fact]
    public void GetAllTest()
    {
        var repo = new Mock<IUserRepository>();
        var x = repo.Object;
        x.GetAll();
        
        repo.Verify(r => r.GetAll(), Times.Once);
    }
    [Fact]
    public void GetByIdTest()
    {
        var repo = new Mock<IUserRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.GetById(guid);
        
        repo.Verify(r => r.GetById(guid), Times.Once);
    }
    [Fact]
    public void DeleteTest()
    {
        var repo = new Mock<IUserRepository>();
        var x = repo.Object;
        var guid = Guid.NewGuid();
        x.Delete(guid);
        
        repo.Verify(r => r.Delete(guid), Times.Once);
    }
    [Fact]
    public void GetByPredicateTest()
    {
        var repo = new Mock<IUserRepository>();
        var x = repo.Object;
        x.GetByPredicate(x=>x.Email=="www@wp.pl");
        
        repo.Verify(r => r.GetByPredicate(x=>x.Email=="www@wp.pl"), Times.Once);
    }
}