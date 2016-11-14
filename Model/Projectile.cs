namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Класс, определяющий снаряд. Содержит также все свойства круглого юнита.
    /// </summary>
    public class Projectile : CircularUnit
    {
        public Projectile(long id, double x, double y, double speedX, double speedY, double angle, Faction faction,
                double radius, ProjectileType type, long ownerUnitId, long ownerPlayerId)
                : base(id, x, y, speedX, speedY, angle, faction, radius)
        {
            Type = type;
            OwnerUnitId = ownerUnitId;
            OwnerPlayerId = ownerPlayerId;
        }

        /// <summary>
        /// Тип снаряда.
        /// </summary>
        public ProjectileType Type { get; }

        /// <summary>
        /// Идентификатор юнита, создавшего данный снаряд.
        /// </summary>
        public long OwnerUnitId { get; }

        /// <summary>
        /// Идентификатор игрока, юнит которого создал данный снаряд или -1.
        /// </summary>
        public long OwnerPlayerId { get; }
    }
}