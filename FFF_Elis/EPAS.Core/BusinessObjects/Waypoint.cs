﻿namespace EPAS.Core.BusinessObjects;

public class Waypoint
{
    public float lat { get; set; } 
    public float lon { get; set; }

    public override string ToString()
    {
        return $"lat: {lat}, lon: {lon}";
    }
}