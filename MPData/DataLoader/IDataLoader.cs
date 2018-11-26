using MPCore;
using System.Collections.Generic;

namespace MPData {
  public interface IDataLoader {
    List<Artist> Load();
  }
}
