namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Класс, определяющий приспешника волшебника одной из фракций. Содержит также все свойства живого юнита.
    /// </summary>
    /// <remarks>
    /// Миньоны, оставшиеся по той или иной причине без хозяина, часто объединяются в небольшие группы и селятся в лесах.
    /// Они крайне настороженно относятся ко всем другим волшебникам и их миньонам.
    /// </remarks>
    public class Minion : LivingUnit
    {
        public Minion(
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
            MinionType type,
            double visionRange,
            int damage,
            int cooldownTicks,
            int remainingActionCooldownTicks)
                : base(id, x, y, speedX, speedY, angle, faction, radius, life, maxLife, statuses)
        {
            Type = type;
            VisionRange = visionRange;
            Damage = damage;
            CooldownTicks = cooldownTicks;
            RemainingActionCooldownTicks = remainingActionCooldownTicks;
        }

        /// <summary>
        /// Тип миньона.
        /// </summary>
        public MinionType Type { get; }

        /// <summary>
        /// Максимальное расстояние (от центра до центра), на котором данный
        /// миньон обнаруживает другие объекты.
        /// </summary>
        public double VisionRange { get; }

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