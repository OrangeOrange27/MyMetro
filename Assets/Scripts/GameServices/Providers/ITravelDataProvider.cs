using Core;

namespace GameServices.Providers
{
    public interface ITravelDataProvider<out T>
        where T : ITravelData
    {
        T GetData();
    }
}