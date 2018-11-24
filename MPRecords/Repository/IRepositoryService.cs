using System.Collections.Generic;

namespace MPRecords {
  public interface IRepositoryService {
    List<Artist> GetArtists();
    Artist GetArtistByName(string name);
    List<Artist> Search(string keyword);
  }
}
