using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PMS.APIFramework.ApiResponseContent
{
    public class ApiResult
    {
        public bool IsSuccess { get; set; }
        public ApiResponseStatus ApiResponseStatus { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string ApiResponseStatusName { get; set; }
        public string Message { get; set; }
    }

    public class ApiResult<TData> : ApiResult
    {
        public TData Data { get; set; }
    }
}
