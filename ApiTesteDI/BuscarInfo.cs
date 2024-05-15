using ApiTesteDI.Container;

namespace ApiTesteDI
{
    public class BuscarInfo : IBuscarInfoId
    {
        private readonly Random _random;
        public BuscarInfo(Random random)
        {
            _random = random;
        }
        public int BuscarInform(int id)
        {             
            int numAleatorio = _random.Next(1, id);             
            return numAleatorio;
        }
    }
}
