namespace dev_events_service.Core;

public sealed class QueryResult : BaseResult
{
    private QueryResult()
    {
    }

    public QueryResult(in object data)
    {
        Data = data;
    }

    public QueryResult(in string error)
    {
        AddError(error);
    }

    public void AddErrorMessage(in string error)
    {
        AddError(error);
    }

    public static QueryResult GetDefaultSuccess()
    {
        return new QueryResult();
    }
}
