﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASiNet.API.TelegramBot.Primitives;
/// <summary>
/// This object represents a point on the map.
/// </summary>
public class Location
{
    /// <summary>
    /// Latitude as defined by sender
    /// </summary>
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }
    /// <summary>
    /// Longitude as defined by sender
    /// </summary>
    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }
    /// <summary>
    /// Optional. The radius of uncertainty for the location, measured in meters; 0-1500
    /// </summary>
    [JsonPropertyName("horizontal_accuracy")]
    public double HorizontalAccuracy { get; set; }
    /// <summary>
    /// Optional. Time relative to the message sending date, during which the location can be updated; in seconds. For active live locations only.
    /// </summary>
    [JsonPropertyName("live_period")]
    public int LivePeriod { get; set; }
    /// <summary>
    /// Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.
    /// </summary>
    [JsonPropertyName("heading")]
    public int Heading { get; set; }
    /// <summary>
    /// Optional. The maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.
    /// </summary>
    [JsonPropertyName("proximity_alert_radius")]
    public int ProximityAlertRadius { get; set; }
}
