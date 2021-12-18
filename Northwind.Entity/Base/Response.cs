using Northwind.Entity.IBase;

namespace Northwind.Entity.Base
{
    public class Response :IResponse
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public object Data { get; set; }
    }

    public class Response<T>:IResponse
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; }
    }
}
