using Conference_Website.Models;

namespace Conference_Website.ResultModels
{
    public interface IResult
    {
        public bool IsSuccess { get; set; }
        public AlertBox Alert { get; set; }

    }
}
