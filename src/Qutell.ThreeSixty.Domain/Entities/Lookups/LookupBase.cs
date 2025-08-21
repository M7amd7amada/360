namespace Qutell.ThreeSixty.Domain.Entities.Lookups
{
    public class LookupBase : ILookupBase 
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
       
    }

   
}
