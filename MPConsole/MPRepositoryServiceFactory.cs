using MPData;
using MPRecords;
using MPRepository;
using System.IO;

namespace MPConsole {
  public class MPRepositoryServiceFactory {
    public IRepositoryService Create() {

      var currentPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
      var assetPath = Path.Combine(Directory.GetParent(currentPath).FullName, "Assets\\data.json");

      return new MPRepositoryService(new MemoryDataStore(new FileDataLoader(assetPath)));
    }
  }
}
