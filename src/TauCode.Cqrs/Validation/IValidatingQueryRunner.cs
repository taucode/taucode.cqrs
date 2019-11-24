﻿using TauCode.Cqrs.Queries;

namespace TauCode.Cqrs.Validation
{
    public interface IValidatingQueryRunner : IQueryRunner
    {
        void Validate<TQuery>(TQuery query) where TQuery : IQuery;
    }
}
