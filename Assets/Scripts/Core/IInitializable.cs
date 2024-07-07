namespace Core
{
    public interface IInitializable<in T>
    {
        void Initialize(T data);
    }
}