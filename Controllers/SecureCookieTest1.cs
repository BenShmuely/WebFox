using System.Net;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;

namespace WebFox.Controllers
{
    public class SecureCookieTest1
    {
        // HttpCookie myCookie = new HttpCookie("Sensitive cookie");
        public void DoPost(HttpResponse response, HttpRequest request)
        {
            DoGet(response, request);
        }

        public void DoGet(HttpResponse response, HttpRequest request)
        {
            Unsafe(response, request);
        }

        public void Unsafe(HttpResponse response, HttpRequest request)
        {
            string password = "p-" + RandomNumberGenerator.GetInt32(200000000, 2000000000);
            Cookie cookie = new Cookie("password",password);
            cookie.Path = "/";
            cookie.Domain = "";
            cookie.Comment = "Cookie Description";
        }
    }
}