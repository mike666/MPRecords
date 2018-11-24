using CommandLine;

namespace MPConsole {
  public class ConsoleOptions {
    [Option('s', "search", Required = false, HelpText = "Search artists by keyword")]
    public string Keyword { get; set; }
    
    [Option('l', "list", Required = false, HelpText = "List all artists")]
    public bool ListAll { get; set; }

    [Option('a', "artist", Required = false, HelpText = "List albums by artist")]
    public string Artist { get; set; }
  }
}
