using System;

namespace Pokemon_seeker.DataAccess.Entities;

public class Pokemon
{
    public Pokemon(
        int id,
         string name, 
         int order, 
         int gender_rate, 
         int capture_rate, 
         int base_happiness, 
         bool is_baby, 
         bool is_legendary, 
         bool is_mythical, 
         int hatch_counter, 
         bool has_gender_differences, 
         bool forms_switchable
        )
    {
        Id = id;
        Name = name;
        Order = order;
        Gender_rate = gender_rate;
        Capture_rate = capture_rate;
        Base_happiness = base_happiness;
        Is_baby = is_baby;
        Is_legendary = is_legendary;
        Is_mythical = is_mythical;
        Hatch_counter = hatch_counter;
        Has_gender_differences = has_gender_differences;
        Forms_switchable = forms_switchable;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public int Order { get; private set; }
    public int Gender_rate { get; private set; }
    public int Capture_rate { get; private set; }
    public int Base_happiness { get; private set; }
    public bool Is_baby { get; private set; }
    public bool Is_legendary { get; private set; }
    public bool Is_mythical { get; private set; }
    public int Hatch_counter { get; private set; }
    public bool Has_gender_differences { get; private set; }
    public bool Forms_switchable { get; private set; }
}
