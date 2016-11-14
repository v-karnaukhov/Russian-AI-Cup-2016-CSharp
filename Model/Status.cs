namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Магический статус, влияющий на живого юнита.
    /// </summary>
    public class Status
    {
        public Status(long id, StatusType type, long wizardId, long playerId, int remainingDurationTicks)
        {
            Id = id;
            Type = type;
            WizardId = wizardId;
            PlayerId = playerId;
            RemainingDurationTicks = remainingDurationTicks;
        }

        /// <summary>
        /// Уникальный идентификатор статуса.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Тип магического статуса.
        /// </summary>
        public StatusType Type { get; }

        /// <summary>
        /// Идентификатор волшебника, наложившего данный статус, или {code -1}.
        /// </summary>
        public long WizardId { get; }

        /// <summary>
        /// Идентификатор игрока, волшебник которого наложил данный статус, или {code -1}.
        /// </summary>
        public long PlayerId { get; }

        /// <summary>
        /// Оставшаяся длительность действия статуса.
        /// </summary>
        public int RemainingDurationTicks { get; }
    }
}