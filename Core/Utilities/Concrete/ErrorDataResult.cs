using Core.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, true)
        {

        }
        public ErrorDataResult(T data) : base(data, true)
        {

        }
        public ErrorDataResult(string message) : base(default, true)
        {

        }
        public ErrorDataResult() : base(default, true)
        {

        }

    }
}