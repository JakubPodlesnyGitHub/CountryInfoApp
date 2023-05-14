namespace CountryInfoApp.HttpHelpers
{
    public class HttpWrapper<T>
    {
        public bool IfSucceeded { get; set; }
        public T Response { get; set; }

        public HttpResponseMessage HttpResponseMessage { get; set; }

        public HttpWrapper(bool ifSucceeded, T response, HttpResponseMessage httpResponseMessage)
        {
            IfSucceeded = ifSucceeded;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }

        public async Task<string> GetBodyAsync()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}