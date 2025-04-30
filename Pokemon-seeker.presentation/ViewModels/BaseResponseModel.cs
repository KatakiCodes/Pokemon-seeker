using System;
using System.Net;
using System.Text.Json.Serialization;

namespace Pokemon_seeker.Presentation.ViewModels;

public abstract class BaseResponseModel
{
    public BaseResponseModel(bool succeeded, HttpStatusCode statusCode)
    {
        Succeeded = succeeded;
        StatusCode = statusCode;
        if(!Succeeded)
            ErrorMessage = (StatusCode == HttpStatusCode.NotFound) ? "Pokemon não localizado!" : "Erro inesperado!";
        else
            ErrorMessage = null;
    }
    public bool Succeeded { get; private set; }
    public HttpStatusCode StatusCode {get; private set;}
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ErrorMessage { get; private set; }
}
