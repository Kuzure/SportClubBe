using System.Net;

namespace SportClub.Infrastructure
{
    public class Response<T>
    {
        public Response()
        {

        }

        public Response(T result)
        {
            Result = result;
            Code = HttpStatusCode.OK;
            IsError = false;
        }

        /// <summary>
        /// Response result
        /// </summary>
        public T? Result { get; set; }

        /// <summary>
        /// Http Status code
        /// </summary>
        public HttpStatusCode Code { get; set; }

        /// <summary>
        /// Optional message
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Error flag
        /// </summary>
        public bool IsError { get; set; }

    }
}
