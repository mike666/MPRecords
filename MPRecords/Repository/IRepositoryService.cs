using System.Collections.Generic;

namespace MPRecords {
  public interface IRepositoryService {
    List<Artist> GetArtists();
    List<string> GetArtistList();
    Artist GetArtistByName(string name);
  }
}
