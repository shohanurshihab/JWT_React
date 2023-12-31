﻿namespace JWT.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[]? Photo { get; set; }
        public string PasswordHash { get; set; }
    }
}
