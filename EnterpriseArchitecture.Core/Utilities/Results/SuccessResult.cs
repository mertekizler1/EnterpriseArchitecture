using EnterpriseArchitecture.Core.Utilities.Results.Common;

namespace EnterpriseArchitecture.Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
        }

        public SuccessResult() : base(true)
        {
        }
    }
}