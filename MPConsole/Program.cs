using MPData;
using MPCore;
using MPRepository;
using MPSearch;
using System.IO;

namespace MPConsole {
  class Program {
    static void Main(string[] args) {
      
      var currentPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
      var assetPath = Path.Combine(Directory.GetParent(currentPath).FullName, "Assets\\data.json");
            
      IRepositoryService repositoryService = new MPRepositoryService(new MemoryDataStore(new FileDataLoader(assetPath)));
      ISearchService searchService = new BasicSearchService(repositoryService);
      
      MPConsole mpConsole = new MPConsole(repositoryService, searchService);

      mpConsole.ReadInput(args);
    }
  }
}