namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Содержит данные о текущем состоянии игрока.
    /// </summary>
    public class Player
    {
        public Player(long id, bool isMe, string name, bool isStrategyCrashed, int score, Faction faction)
        {
            Id = id;
            IsMe = isMe;
            Name = name;
            IsStrategyCrashed = isStrategyCrashed;
            Score = score;
            Faction = faction;
        }

        /// <summary>
        /// Уникальный идентификатор игрока.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Возвращает true в том и только в том случае, если этот игрок ваш.
        /// </summary>
        public bool IsMe { get; }

        /// <summary>
        /// Имя игрока.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Возвращает специальный флаг—показатель того, что стратегия игрока «упала».
        /// </summary>
        /// <remarks>
        /// Более подробную информацию можно найти в документации к игре.
        /// </remarks>
        public bool IsStrategyCrashed { get; }

        /// <summary>
        /// Количество баллов, набранное игроком.
        /// </summary>
        public int Score { get; }

        /// <summary>
        /// Фракция, к которой принадлежит данный игрок.
        /// </summary>
        public Faction Faction { get; }
    }
}