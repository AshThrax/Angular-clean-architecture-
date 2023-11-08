using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace Application.Common.Exceptions
{
    public class ValidationException : Exception
    {
        public IDictionary<string, string[]> Errors { get; }
        public ValidationException() : base("One or more failures have occured.")
        {

        }
        public ValidationException(IEnumerable<ValidationFailure> failures)
            :this()
        {
            Errors = failures.
                GroupBy(e => e.PropertyName, e => e.ErrorMessage)
                .ToDictionary(failures => failures.Key, failures => failures.ToArray());
        }

    }
}
