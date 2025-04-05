using Fuck_API.Model;

namespace Fuck_API.Services
{
    public interface IParsingService
    {
        Task<List<Item>> Parse(int pageNumber, int pageSize);
    }
}
