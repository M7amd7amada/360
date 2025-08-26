namespace Qutell.ThreeSixty.Application.DTOs
{
    public class CreateDto<T>
    {
        public T Entity { get; set; }
    }

    public class UpdateDto<TKey, T>
    {
        public TKey Id { get; set; }
        public T Entity { get; set; }
    }

    public class ReadDto<TKey, T>
    {
        public TKey Id { get; set; }
        public T Entity { get; set; }
    }
}
