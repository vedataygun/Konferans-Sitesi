using Conference_Website.Models;

namespace Conference_Website.ResultModels
{
    public class Result : IResult
    {
        public bool IsSuccess { get ; set ; }
        public AlertBox Alert { get; set ; }


        public Result(bool isSuccess):this(isSuccess,new AlertBox())
        {

        }
        public Result(bool isSuccess, AlertBox alert)
        {
            IsSuccess = isSuccess;
            Alert = alert;
        }

    }
}
