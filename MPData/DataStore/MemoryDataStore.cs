using MPCore;
using System.Collections.Generic;

namespace MPData {
  public class MemoryDataStore : IDataStore  {
    private IDataLoader _DataLoader = null;
    private List<Artist> _Artists = null;

    public MemoryDataStore(IDataLoader dataloader) {
      _DataLoader = dataloader;
    }

    public List<Artist> GetArtists() {
      if (_Artists == null) {
        _Artists = _DataLoader.Load();
      }

      return _Artists;
    }
  }
}
