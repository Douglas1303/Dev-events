namespace dev_events_service.Core;

public interface IResult
{
    IList<string> Messages { get; }
    StatusResult Status { get; }
    object Data { get; set; }
}
