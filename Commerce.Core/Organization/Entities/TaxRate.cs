﻿namespace Commerce.Core.Organization.Entities;

public class TaxRate
{
    public int Id { get; set; }
    public int TaxId { get; set; }
    public string Name { get; set; } = null!;
    public double Value { get; set; }

    public Tax Tax { get; set; } = null!;
}
