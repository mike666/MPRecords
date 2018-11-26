using MPCore;
using System;
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

    public Artist GetArtistByName(string name) {
      return _DataStore.GetArtists().FirstOrDefault(c => c.Title.Equals(name, StringComparison.InvariantCultureIgnoreCase));
    }
  }
}
