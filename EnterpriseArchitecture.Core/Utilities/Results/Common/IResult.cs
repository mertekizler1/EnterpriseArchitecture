namespace EnterpriseArchitecture.Core.Utilities.Results.Common
{
    public interface IResult
    {
        bool Success { get; }

        string Message { get; }
    }
}