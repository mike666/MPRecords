using System.IO;

namespace MPData {
  public class FileReader  {
    
    public string Read(string path) {
      return File.ReadAllText(path);
    }
  }
}
