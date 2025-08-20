namespace Qutell.ThreeSixty.Domain.Entities.Lookups
{
    public interface IAuditable
    {
         DateTime CreatedAt { get; set; }DateTime? UpdatedAt { get; set; }    
    }
}
