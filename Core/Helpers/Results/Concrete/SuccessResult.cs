﻿namespace Core.Helpers.Results.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(bool success, string message) : base(true, message)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
