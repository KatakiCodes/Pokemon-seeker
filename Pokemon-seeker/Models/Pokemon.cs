using System;

namespace Pokemon_Seeker.Models;

public class Pokemon
{
    public Pokemon(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; private set; }
    public string Name { get; private set; }
}
