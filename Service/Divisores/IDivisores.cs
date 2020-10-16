using System.Collections.Generic;

namespace Divisores.Service.Divisores
{
    public interface IDivisores
    {
        List<int> BuscaDivisores(int dividendo);
        List<int> BuscaDivisoresPrimos(int dividendo);
    }
}