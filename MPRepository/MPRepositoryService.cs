using MPRecords;
using System.Collections.Generic;
using System.Linq;

namespace MPRepository {
  public class MPRepositoryService : IRepositoryService {
    private IDataStore _DataStore;

    public MPRepositoryService(IDataStore dataStore) {
      _DataStore = dataStore;
    }

    public List<Artist> GetArtists() {
      return _DataStore.GetArtists();
    }

    public List<string> GetArtistList() {
      return _DataStore.GetArtists().Select(c => c.Title).ToList();
    }

    public Artist GetArtistByName(string name) {
      return _DataStore.GetArtists().FirstOrDefault(c => c.Title.Equals(name, System.StringComparison.InvariantCultureIgnoreCase));
    }
  }
}
