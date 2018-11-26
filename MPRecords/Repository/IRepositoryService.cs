using System.Collections.Generic;

namespace MPCore {
  public interface IRepositoryService {
    List<Artist> GetArtists();
    Artist GetArtistByName(string name);
  }
}
