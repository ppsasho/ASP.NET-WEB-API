﻿namespace UsersAPI
{
    public class User
    {
        public User()
        {
            
        }
        public User(int id, string username)
        {
            Id = id;
            Username = username;
        }
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
