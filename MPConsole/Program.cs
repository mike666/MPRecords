using System;

namespace MPConsole {
  class Program {
    static void Main(string[] args) {
      
      MPRepositoryServiceFactory factory = new MPRepositoryServiceFactory();

      MPConsole mpConsole = new MPConsole(factory.Create());

      mpConsole.ReadInput(args);
    }
  }
}