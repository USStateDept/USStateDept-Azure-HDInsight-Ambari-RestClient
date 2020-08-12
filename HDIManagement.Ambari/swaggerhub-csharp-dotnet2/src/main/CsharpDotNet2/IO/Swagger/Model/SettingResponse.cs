using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SettingResponse {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets SettingType
    /// </summary>
    [DataMember(Name="setting_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "setting_type")]
    public string SettingType { get; set; }

    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedBy
    /// </summary>
    [DataMember(Name="updated_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_by")]
    public string UpdatedBy { get; set; }

    /// <summary>
    /// Gets or Sets UpdateTimestamp
    /// </summary>
    [DataMember(Name="update_timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update_timestamp")]
    public long? UpdateTimestamp { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SettingResponse {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SettingType: ").Append(SettingType).Append("\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
      sb.Append("  UpdateTimestamp: ").Append(UpdateTimestamp).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
