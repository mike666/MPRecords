using System.Collections.Generic;

namespace MPRecords {
  public class Artist {
    public string Title { get; set; }
    public string Url { get; set; }
    public List<Album> Albums { get; set; } = new List<Album>();
  }
}
