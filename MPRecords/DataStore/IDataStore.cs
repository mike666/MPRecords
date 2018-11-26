using System.Collections.Generic;

namespace MPCore {
  public interface IDataStore {
    List<Artist> GetArtists();
  }
}
