using HeroesWorld.Domain.Enums;

namespace HeroesWorld.Domain.Entities
{
    public class Character : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public CharacterQuality Quality { get; set; }
        public string? PhotoBase64 { get; set; }
        public int ChanceOfDropping { get; set; }
    }
}
