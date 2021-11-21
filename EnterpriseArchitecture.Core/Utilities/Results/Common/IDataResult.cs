namespace EnterpriseArchitecture.Core.Utilities.Results.Common
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}