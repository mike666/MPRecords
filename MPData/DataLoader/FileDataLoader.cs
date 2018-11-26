using MPCore;
using System.Collections.Generic;

namespace MPData {
  public class FileDataLoader : IDataLoader {
    private string _FilePath;
    private FileReader _FileReader = null;
    private JsonToOjectConvertor _JsonToOjectConvertor = null;

    public FileDataLoader(string filePath) {
      _FilePath = filePath;
      _FileReader = new FileReader();
      _JsonToOjectConvertor = new JsonToOjectConvertor();
    }

    public List<Artist> Load() {
      string json = _FileReader.Read(_FilePath);

      return _JsonToOjectConvertor.Convert<List<Artist>>(json);
    }
  }
}
