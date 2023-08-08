using System;

public class MyHttpClient
{
    private static readonly HttpClient httpClient;

    static MyHttpClient()
    {
        httpClient = new HttpClient();
        // Set any global headers, timeouts, base addresses etc. here
    }

    public static HttpClient Instance
    {
        get { return httpClient; }
    }
}
