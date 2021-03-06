﻿using CommandLine;
using MPCore;
using System;
using System.Collections.Generic;

namespace MPConsole {
  public class MPConsole {
    public enum ExitCode : int {
      Success = 0,
      UnknownError = 10
    }

    private IRepositoryService _RepositoryService;
    private ISearchService _SearchService;

    public MPConsole(IRepositoryService repositoryService, ISearchService searchService) {
      _RepositoryService = repositoryService;
      _SearchService = searchService;
    }

    public void ReadInput(string[] args) {
      Parser.Default.ParseArguments<ConsoleOptions>(args).WithParsed<ConsoleOptions>(opts => RunOptions(opts));
    }

    private void RunOptions(ConsoleOptions options) {
      if (options.ListAll) {
        ListArtists();
      } else if (!String.IsNullOrEmpty(CleanString(options.Artist))) {
        listAlbums(options.Artist);
      } else if (!String.IsNullOrEmpty(CleanString(options.Keyword))) {
        Search(options.Keyword);
      }

      Environment.Exit((int)ExitCode.Success);
    }

    private void ListArtists() {
      WriteArtists(_RepositoryService.GetArtists());
    }
    
    private void WriteArtists(List<Artist> artists) {
      foreach (Artist artist in artists) {
        WriteLine(artist.Title);
      }
    }
        
    private void listAlbums(string artistName) {
      Artist artist = _RepositoryService.GetArtistByName(artistName);

      if (artist == null) {
        WriteLine(String.Format("Artist not found.", artistName));

        return;
      }

      foreach (Album album in artist.Albums) {
        WriteLine($"{album.Title} ({album.Rating}/10)");
      }
    }
        
    private void Search(string keyword) {
      WriteLine($"Search keyword: {keyword}");

      SearchResult result = _SearchService.Search(keyword);
            
      if (result.Artists.Count == 0) {
        WriteLine("No results found");

        return;
      }

      WriteArtists(result.Artists);
    }

    private string CleanString(string s) {
      return s;
    }

    private void WriteLine(string line) {
      Console.WriteLine(line);
    }
  }
}
