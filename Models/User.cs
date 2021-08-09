using System;

namespace imagent_server.Models
{
    public class User
    {
        public int id {get; set;}
        public string email {get; set;}
        public string password {get; set;}
        public DateTime date_created {get; set;}

        public User(string _email, string _password) => (email, password) = (_email, _password);
    }
}