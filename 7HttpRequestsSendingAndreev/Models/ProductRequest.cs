using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace HttpRequestsSendingAndreev.Models;

public class ProductRequest
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
    public ProductRequest(

    string title,
    string description
    )
    {
        Title = title;
        Description = description;
    }
}
