using MPRecords;
using System.Collections.Generic;

namespace MPData {
  public interface IDataLoader {
    List<Artist> Load();
  }
}
