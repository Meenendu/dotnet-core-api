using dotnet_core_api.Models;

namespace dotnet_core_api.Dtos.Character
{
    public class GetCharacterDto
    {
          public int Id { get; set; }
        public string Name { get; set; }="Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; }=10;
        public int Defence { get; set; }=10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}