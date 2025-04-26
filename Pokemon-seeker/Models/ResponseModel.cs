using System;
using System.Net;
using System.Text.Json.Serialization;
using Pokemon_Seeker.Models;

namespace Pokemon_seeker.Models;

public class ResponseModel
{
    public ResponseModel(HttpStatusCode httpStatusCode)
    {
        HttpStatusCode = httpStatusCode;
    }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Pokemon? Pokemon { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Message {get; set; }
    public HttpStatusCode HttpStatusCode {get; set; }
}
