using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Entities
{
    public class Resultado
    {
        public string Mensagem { get; set; }
        public bool Sucesso { get; set; }
        public int Error { get; set; }
        public RoboEntity Robo { get; set; }
        public Resultado()
        {
            Robo = new RoboEntity();
        }
        public Resultado(bool sucesso)
        {
            Sucesso = sucesso;
            Robo = new RoboEntity();
        }
    }
}
