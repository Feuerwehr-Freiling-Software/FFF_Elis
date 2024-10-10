namespace EPAS.Core.Models;

public class Qualifications
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ApplicationUser> Users { get; set; }
    public string ChipColor { get; set; }
}