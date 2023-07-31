using Conference_Website.Models;
using System.Collections.Generic;

namespace Conference_Website.ResultModels
{
    public class DataResult<T> :IResult  
    {
        public List<T> Data { get; set; }
        public bool IsSuccess { get; set; }
        public AlertBox Alert { get ; set ; }

        public DataResult(bool isSuccess) : this(isSuccess, default(T) )
        {

        }

        public DataResult(bool isSuccess, T data) : this(isSuccess, new List<T>() { data })
        {

        }
        public DataResult(bool isSuccess, List<T> data):this(isSuccess ,new AlertBox(), data)
        {
         
        }

        public DataResult(bool isSuccess, AlertBox alert, List<T> data) 
        {
            IsSuccess = isSuccess;
            Alert = alert;
            Data = data;
        }
    }
}
