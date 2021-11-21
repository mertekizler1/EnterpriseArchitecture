using EnterpriseArchitecture.Core.Utilities.Results.Common;

namespace EnterpriseArchitecture.Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}