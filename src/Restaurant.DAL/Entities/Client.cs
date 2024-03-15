﻿namespace Restaurant.DAL.Entities;

public class Client
{
    public int ClientId { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public int Sale { get; set; } = 5;
    public ICollection<Order>? Orders { get; set; }
}