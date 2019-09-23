namespace ApiRest.Entities
{
    public class RoboEntity
    {
        public int EixoX { get; set; }
        public int EixoY { get; set; }
        public string Face { get; set; }

        public RoboEntity()
        {
            EixoX = 0;
            EixoY = 0;
            Face = "N";
        }
    }
}