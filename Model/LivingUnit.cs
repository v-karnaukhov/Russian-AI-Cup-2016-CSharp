using System;

namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Класс, определяющий живого юнита круглой формы.
    /// </summary>
    public abstract class LivingUnit : CircularUnit
    {
        private readonly Status[] _statuses;

        protected LivingUnit(
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
            Status[] statuses)
                : base(id, x, y, speedX, speedY, angle, faction, radius)
        {
            Life = life;
            MaxLife = maxLife;

            _statuses = new Status[statuses.Length];
            Array.Copy(statuses, _statuses, statuses.Length);
        }

        /// <summary>
        /// Текущее количество жизненной энергии.
        /// </summary>
        public int Life { get; }

        /// <summary>
        /// Максимальное количество жизненной энергии.
        /// </summary>
        public int MaxLife { get; }

        /// <summary>
        /// Магические статусы, влияющие на живого юнита.
        /// </summary>
        public Status[] Statuses
        {
            get
            {
                if (_statuses == null)
                {
                    return null;
                }

                var statuses = new Status[_statuses.Length];
                Array.Copy(_statuses, statuses, _statuses.Length);

                return statuses;
            }
        }
    }
}