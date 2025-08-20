namespace Qutell.ThreeSixty.Domain.Entities.Lookups
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
        
    }
}
