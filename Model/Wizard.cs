using System;

namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Класс, определяющий волшебника. Содержит также все свойства живого юнита.
    /// </summary>
    public class Wizard : LivingUnit
    {
        private readonly SkillType[] _skills;
        private readonly int[] _remainingCooldownTicksByAction;
        private readonly Message[] _messages;

        public Wizard(long id, double x, double y, double speedX, double speedY, double angle, Faction faction,
                double radius, int life, int maxLife, Status[] statuses, long ownerPlayerId, bool isMe, int mana,
                int maxMana, double visionRange, double castRange, int xp, int level, SkillType[] skills,
                int remainingActionCooldownTicks, int[] remainingCooldownTicksByAction, bool isMaster,
                Message[] messages)
                : base(id, x, y, speedX, speedY, angle, faction, radius, life, maxLife, statuses)
        {
            OwnerPlayerId = ownerPlayerId;
            IsMe = isMe;
            Mana = mana;
            MaxMana = maxMana;
            VisionRange = visionRange;
            CastRange = castRange;
            Xp = xp;
            Level = level;

            _skills = new SkillType[skills.Length];
            Array.Copy(skills, _skills, skills.Length);

            RemainingActionCooldownTicks = remainingActionCooldownTicks;

            _remainingCooldownTicksByAction = new int[remainingCooldownTicksByAction.Length];
            Array.Copy(remainingCooldownTicksByAction, _remainingCooldownTicksByAction, remainingCooldownTicksByAction.Length);

            IsMaster = isMaster;

            _messages = new Message[messages.Length];
            Array.Copy(messages, _messages, messages.Length);
        }

        /// <summary>
        /// Идентификатор игрока, которому принадлежит волшебник.
        /// </summary>
        public long OwnerPlayerId { get; }

        /// <summary>
        /// Возвращает true в том и только том случае, если этот волшебник ваш.
        /// </summary>
        public bool IsMe { get; }

        /// <summary>
        /// Текущее количество магической энергии волшебника.
        /// </summary>
        public int Mana { get; }

        /// <summary>
        /// Максимальное количество магической энергии волшебника.
        /// </summary>
        public int MaxMana { get; }

        /// <summary>
        /// Максимальное расстояние (от центра до центра), на котором данный
        /// волшебник обнаруживает другие объекты.
        /// </summary>
        public double VisionRange { get; }

        /// <summary>
        /// Максимальное расстояние (от центра волшебника), которое может
        /// преодолеть выпущенный им магический снаряд.
        /// <remarks>
        /// Также является максимально возможной дальностью применения заклинаний, накладывающих
        /// на цель магический статус(HASTE и SHIELD).
        /// </remarks>
        /// </summary>
        public double CastRange { get; }

        /// <summary>
        /// Количество очков опыта, полученное волшебником в процессе игры.
        /// </summary>
        public int Xp { get; }

        /// <summary>
        /// Текущий уровень волшебника.
        /// <remarks>
        /// Начальный уровень каждого волшебника равен 0, а максимальный—
        /// game.levelUpXpValues.length.
        /// В некоторых режимах игры рост уровня волшебника может быть заблокирован.
        /// </remarks>
        /// </summary>
        public int Level { get; }

        /// <summary>
        /// Умения, изученные волшебником.
        /// </summary>
        public SkillType[] Skills
        {
            get
            {
                if (_skills == null)
                {
                    return null;
                }

                SkillType[] skills = new SkillType[_skills.Length];
                Array.Copy(_skills, skills, _skills.Length);
                return skills;
            }
        }

        /// <summary>
        /// Количество тиков, оставшееся до любого следующего действия.
        /// <remarks>
        /// Для совершения произвольного действия actionType необходимо, чтобы оба значения
        /// remainingActionCooldownTicks и
        /// remainingCooldownTicksByAction[actionType.ordinal()] были равны нулю.
        /// </remarks>
        /// </summary>
        public int RemainingActionCooldownTicks { get; }

        /// <summary>
        /// Массив целых неотрицательных чисел. Каждая ячейка массива содержит
        /// значение количества тиков, оставшегося до совершения следующего действия с
        /// соответствующим индексом.
        /// <remarks>
        /// Например, remainingCooldownTicksByAction[0] соответствует действию NONE и всегда равно
        /// нулю.remainingCooldownTicksByAction[1] соответствует действию STAFF и равно количеству
        /// тиков, оставшемуся до совершения данного действия.remainingCooldownTicksByAction[2]
        /// соответствует действию MAGIC_MISSILE и так далее.
        /// Для совершения произвольного действия actionType необходимо, чтобы оба значения
        /// remainingActionCooldownTicks и
        /// remainingCooldownTicksByAction[actionType.ordinal()] были равны нулю.
        /// </remarks>
        /// </summary>
        public int[] RemainingCooldownTicksByAction
        {
            get
            {
                if (_remainingCooldownTicksByAction == null)
                {
                    return null;
                }

                int[] remainingCooldownTicksByAction = new int[_remainingCooldownTicksByAction.Length];
                Array.Copy(_remainingCooldownTicksByAction, remainingCooldownTicksByAction, _remainingCooldownTicksByAction.Length);
                return remainingCooldownTicksByAction;
            }
        }

        /// <summary>
        /// Возвращает true в том и только том случае, если этот волшебник является верховным.
        /// <remarks>
        /// Количество верховных волшебников в каждой фракции строго равно одному.
        /// </remarks>
        /// </summary>
        public bool IsMaster { get; }

        /// <summary>
        /// сообщения, предназначенные данному волшебнику, если есть право на их просмотр.
        /// <remarks>
        /// Стратегия может просматривать только сообщения, адресатом которых является управляемый
        /// ею волшебник.
        /// </remarks>
        /// </summary>
        public Message[] Messages
        {
            get
            {
                if (_messages == null)
                {
                    return null;
                }

                Message[] messages = new Message[_messages.Length];
                Array.Copy(_messages, messages, _messages.Length);
                return messages;
            }
        }
    }
}