﻿namespace BookStore.Admin.Models.AuthDtos;

public class LoginResult
{
    public string Id { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public bool EmailConfirmed { get; set; }
    public List<string> Roles { get; set; } = new();
    public string Token { get; set; } = string.Empty;
    public DateTime ExpireAt { get; set; }
}