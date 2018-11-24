﻿using CommandLine;
using MPRecords;
using System;
using System.Collections.Generic;

namespace MPConsole {
  public class MPConsole {
    public enum ExitCode : int {
      Success = 0,
      UnknownError = 10
    }

    private IRepositoryService _RepositoryService;

    public MPConsole(IRepositoryService repositoryService) {
      _RepositoryService = repositoryService;
    }

    public void ReadInput(string[] args) {
      Parser.Default.ParseArguments<ConsoleOptions>(args)
      .WithParsed<ConsoleOptions>(opts => RunOptions(opts)
      );
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
      foreach (string artistName in _RepositoryService.GetArtistList()) {
        WriteLine(artistName);
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
    }

    private string CleanString(string s) {
      return s;
    }

    private void WriteLine(string line) {
      Console.WriteLine(line);
    }
  }
}
