namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Класс, определяющий строение. Фракционные строения самостоятельно атакуют противников в определённом радиусе.
    /// </summary>
    /// <remarks>
    /// Строения не могут быть заморожены(FROZEN).
    /// </remarks>
    public class Building : LivingUnit
    {
        public Building(
            long id,
            double x,
            double y,
            double speedX,
            double speedY,
            double angle,
            Faction faction,
            double radius,
            int life,
            int maxLife,
            Status[] statuses,
            BuildingType type,
            double visionRange,
            double attackRange,
            int damage,
            int cooldownTicks,
            int remainingActionCooldownTicks)
                : base(id, x, y, speedX, speedY, angle, faction, radius, life, maxLife, statuses)
        {
            Type = type;
            VisionRange = visionRange;
            AttackRange = attackRange;
            Damage = damage;
            CooldownTicks = cooldownTicks;
            RemainingActionCooldownTicks = remainingActionCooldownTicks;
        }

        /// <summary>
        /// Nип строения.
        /// </summary>
        public BuildingType Type { get; }

        /// <summary>
        /// Максимальное расстояние (от центра до центра), на котором данное
        /// строение обнаруживает другие объекты.
        /// </summary>
        public double VisionRange { get; }

        /// <summary>
        /// Максимальное расстояние (от центра до центра), на котором данное
        /// строение может атаковать другие объекты.
        /// </summary>
        public double AttackRange { get; }

        /// <summary>
        /// Урон одной атаки.
        /// </summary>
        public int Damage { get; }

        /// <summary>
        /// Интервал между атаками.
        /// </summary>
        public int CooldownTicks { get; }

        /// <summary>
        /// Количество тиков, оставшееся до следующей атаки.
        /// </summary>
        public int RemainingActionCooldownTicks { get; }
    }
}