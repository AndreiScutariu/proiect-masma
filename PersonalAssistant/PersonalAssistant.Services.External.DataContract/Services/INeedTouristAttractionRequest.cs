using PersonalAssistant.Common.Messages;

namespace PersonalAssistant.Services.External.DataContract.Services
{
    public interface INeedTouristAttractionRequest
    {
    }

    public class NeedTouristAttractionRequest : HeaderMessage, INeedTouristAttractionRequest
    {
    }
}