using System;

namespace PokemonSeeker.Entities;

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Gen { get; set; }
    public string[] Types { get; set; }
    public List<Abilities> Abilities { get; set; }
    public string Height { get; set; }
    public string Weight { get; set; }
    public bool Mega { get; set; }
    public BaseStats BaseStats { get; set; }
    public Training Training { get; set; }
    public Breeding Breeding { get; set; }
    public string Sprite { get; set; }
}
