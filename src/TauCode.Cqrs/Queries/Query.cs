﻿namespace TauCode.Cqrs.Queries
{
    public abstract class Query<TResult> : IQuery<TResult>
    {
        private TResult _result;

        public void SetResult(TResult result)
        {
            _result = result;
        }

        public TResult GetResult()
        {
            return _result;
        }
    }
}
