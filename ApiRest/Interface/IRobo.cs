using ApiRest.Entities;

namespace ApiRest.Interface
{
    public interface IRobo
    {
        Resultado Identificar(string comando);
    }
}