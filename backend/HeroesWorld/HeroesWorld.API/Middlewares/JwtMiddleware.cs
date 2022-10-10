namespace HeroesWorld.API.Middlewares
{
    public class JwtMiddleware
    {
        private RequestDelegate next;

        public JwtMiddleware(RequestDelegate requestDelegate)
        {
            this.next = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string? token;
            if(context.Request.Cookies.TryGetValue("jwtToken",out token)){
                context.Request.Headers.Add("Authorization", "Bearer " + token);
            }
            await this.next.Invoke(context);
        }
    }
}
