using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class Result
    {
        public bool Success { get; set; }
        public string[] Errors { get; set; }
        internal Result(bool succeeded ,IEnumerable<string> error) { 
            Success = succeeded;
            Errors = error.ToArray();
        }

        public static Result Successed()
        { 
            return new Result(true,Array.Empty<string>());
        }
        public static Result Failure(IEnumerable<string> errors)
        {
            return new Result(false, errors);
        }

    }
}
