namespace FFF_Elis.Components.BusinessObjects;

/// <summary>
/// Represents a visual item on the visualization page when no deployment is active.
/// </summary>
public class VisualItem
{
    /// <summary>
    /// Gets or sets the name of the visual item.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the type of the visual item.
    /// </summary>
    public VisualItemType Type { get; set; }

    /// <summary>
    /// Gets or sets the URL associated with the visual item.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Gets or sets the description of the visual item.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the duration for which the visual item is displayed.
    /// </summary>
    public int Duration { get; set; }
}