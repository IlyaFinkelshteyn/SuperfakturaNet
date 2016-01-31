using System;

namespace Superfaktura
{
    public class SuperfakturaClient
    {
        private string email;
        private string token;

        public SuperfakturaClient(string email, string token)
        {
            this.email = email;
            this.token = token;
        }
    }
}
