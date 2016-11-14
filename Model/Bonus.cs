namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Класс, определяющий бонус — неподвижный полезный объект. Содержит также все свойства круглого юнита.
    /// </summary>
    public class Bonus : CircularUnit
    {
        public Bonus(
            long id,
            double x,
            double y,
            double speedX,
            double speedY,
            double angle,
            Faction faction,
            double radius,
            BonusType type)
            : base(id, x, y, speedX, speedY, angle, faction, radius)
        {
            Type = type;
        }

        /// <summary>
        /// Тип бонуса.
        /// </summary>
        public BonusType Type { get; }
    }
}