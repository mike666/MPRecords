using MPRecords;

using System;

namespace MPConsole {
  class Program {
    static void Main(string[] args) {
      MPRepositoryServiceFactory factory = new MPRepositoryServiceFactory();

      MPConsole mpConsole = new MPConsole(factory.Create());

      mpConsole.listAlbums("Dinosaur Jr.");

      Console.ReadKey();
    }
  }

  public class MPConsole {
    private IRepositoryService _RepositoryService;

    public MPConsole(IRepositoryService repositoryService) {
      _RepositoryService = repositoryService;
    }

    public void ListArtists() {
      foreach (string artistName in _RepositoryService.GetArtistList()) {
        WriteLine(artistName);
      }
    }

    public void listAlbums(string artistName) {
      Artist artist = _RepositoryService.GetArtistByName(artistName);

      if (artist == null) {
        WriteLine(String.Format("Artist not found.", artistName));

        return;
      }

      foreach (Album album in artist.Albums) {
        WriteLine(String.Format("{0} ({1})", album.Title, album.Rating));
      }
    }

    public void WriteLine(string line) {
      Console.WriteLine(line);
    }
  }
}
