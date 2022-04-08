using Newtonsoft.Json;

namespace WebApplication1
{

    public class PostParams : BaseModel<PostParams>
    {
        [JsonProperty("prop")]
        public int MyProperty { get; set; }
    }
}
