using TinDo.Data.Infrastructure;

namespace TinDo.Data
{
    public class TinDoContext : DataContext
    {
        public TinDoContext() : base("TinDoContext")
        {
        }
    }
}
