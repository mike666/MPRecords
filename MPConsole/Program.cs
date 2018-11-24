using System;

namespace MPConsole {
  class Program {
    static void Main(string[] args) {
      
      MPRepositoryServiceFactory factory = new MPRepositoryServiceFactory();

      MPConsole mpConsole = new MPConsole(factory.Create());

      mpConsole.ReadInput(args);

      Environment.Exit(0);
    }
  }
}

/* enum ExitCode : int {
  Success = 0,
  InvalidLogin = 1,
  InvalidFilename = 2,
  UnknownError = 10
}
 */
