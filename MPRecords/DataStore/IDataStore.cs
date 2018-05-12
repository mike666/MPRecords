using System.Collections.Generic;

namespace MPRecords {
  public interface IDataStore {
    List<Artist> GetArtists();
  }
}
