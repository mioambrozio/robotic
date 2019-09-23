using ApiRest.Entities;
using ApiRest.Interface;

namespace ApiRest.Models
{
    public class Robo : IRobo
    {
        private bool ValidarPosicao(int valor, string face)
        {
            if ((face.Equals("N") || face.Equals("E")) && (valor.Equals(5)))
                return false;

            if ((face.Equals("W") || face.Equals("S")) && (valor.Equals(0)))
                return false;

            return true;
        }

        public Resultado Identificar(string comando)
        {
            RoboEntity robo = new RoboEntity();

            Resultado resultado = new Resultado(true);

            foreach (char c in comando)
            {
                switch (c.ToString())
                {
                    case "M":
                        {
                            if (robo.Face.Equals("N"))
                            {
                                if (ValidarPosicao(robo.EixoY, robo.Face))
                                    robo.EixoY++;
                                else
                                    resultado.Sucesso = false;
                            }
                            else if (robo.Face.Equals("S"))
                                if (ValidarPosicao(robo.EixoY, robo.Face))
                                    robo.EixoY--;
                                else
                                    resultado.Sucesso = false;
                            else if (robo.Face.Equals("E"))
                                if (ValidarPosicao(robo.EixoX, robo.Face))
                                    robo.EixoX++;
                                else
                                    resultado.Sucesso = false;
                            else if (robo.Face.Equals("W"))
                                if (ValidarPosicao(robo.EixoX, robo.Face))
                                    robo.EixoX--;
                                else
                                    resultado.Sucesso = false;

                            break;
                        }

                    case "L":
                        {
                            if (robo.Face.Equals("N"))
                                robo.Face = "W";
                            else if (robo.Face.Equals("S"))
                                robo.Face = "E";
                            else if (robo.Face.Equals("E"))
                                robo.Face = "N";
                            else if (robo.Face.Equals("W"))
                                robo.Face = "S";

                            break;
                        }

                    case "R":
                        {
                            if (robo.Face.Equals("N"))
                                robo.Face = "E";
                            else if (robo.Face.Equals("S"))
                                robo.Face = "W";
                            else if (robo.Face.Equals("E"))
                                robo.Face = "S";
                            else if (robo.Face.Equals("W"))
                                robo.Face = "N";

                            break;
                        }

                    default:
                        {
                            resultado.Sucesso = false;
                            break;
                        }
                }
            }

            if (resultado.Sucesso)
                resultado.Robo = robo;
            else
            {
                resultado.Error = 400;
                resultado.Mensagem = "400 Bad Request";
            }
            
            return resultado;
        }
    }
}
