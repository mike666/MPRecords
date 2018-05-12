using Newtonsoft.Json;

namespace MPData {
  public class JsonToOjectConvertor  {
    
    public T Convert<T>(string json) {
      return JsonConvert.DeserializeObject<T>(json);
    }
  }
}
