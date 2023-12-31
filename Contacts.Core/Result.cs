﻿namespace Contacts.Core
{
    public class Result<T>
    {
        private readonly T? _value;
        private readonly Exception? _exception;
        private readonly bool _isSuccess;

        /// <summary>
        /// Creates a result with a value
        /// </summary>
        /// <param name="value"></param>
        public Result(T value)
        {
            _value = value;
            _isSuccess = true;
            _exception = null;
        }

        /// <summary>
        /// Creates a result with an exception
        /// </summary>
        /// <param name="ex"></param>
        public Result(Exception ex)
        {
            _isSuccess = false;
            _exception = ex;
            _value = default;
        }

        /// <summary>
        /// Gets the value if the result is successful
        /// </summary>
        /// <returns></returns>
        public T? GetValue()
        {
            if (_isSuccess && _value != null)
                return _value;

            return default;
        }

        /// <summary>
        /// Returns true if the result is successful
        /// </summary>
        /// <returns></returns>
        public bool IsSuccess()
        {
            return _isSuccess;
        }

        /// <summary>
        /// Gets the exception if the result is not successful
        /// </summary>
        /// <returns></returns>
        public Exception GetException()
        {
            if (_exception != null && !_isSuccess)
                return _exception;

            return new Exception();
        }

    }
    
}
