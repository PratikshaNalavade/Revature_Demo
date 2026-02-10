using Xunit;
using System.Linq;

public class InMemoryRepositoryTests
{
    [Fact]
    public void Add_ShouldIncreaseCount()
    {
        IRepository<string> repo = new InMemoryRepository<string>();

        repo.Add("Item1");

        Assert.Single(repo.GetAll());
    }

    [Fact]
    public void GetById_ShouldReturnCorrectItem()
    {
        IRepository<string> repo = new InMemoryRepository<string>();
        repo.Add("Item1");

        var item = repo.GetById(1);

        Assert.Equal("Item1", item);
    }
}
