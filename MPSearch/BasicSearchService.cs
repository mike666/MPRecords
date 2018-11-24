using MPRecords;
using System.Linq;

namespace MPSearch {
  public class BasicSearchService : ISearchService {
    private IRepositoryService _RepositoryService;

    public BasicSearchService(IRepositoryService repositoryService) {
      _RepositoryService = repositoryService;
    }

    public SearchResult Search(string keyword) {
      return new SearchResult {
        Artists = _RepositoryService.GetArtists().FindAll(a => a.Title.ToLower().Contains(keyword.ToLower())).ToList()
      };
    }
  }
}
