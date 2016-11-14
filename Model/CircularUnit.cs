namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Базовый класс для определения круглых объектов. Содержит также все свойства юнита.
    /// </summary>
    public abstract class CircularUnit : Unit
    {
        protected CircularUnit(
            long id,
            double x,
            double y,
            double speedX,
            double speedY,
            double angle,
            Faction faction,
            double radius)
                : base(id, x, y, speedX, speedY, angle, faction)
        {
            Radius = radius;
        }

        /// <summary>
        /// Радиус объекта.
        /// </summary>
        public double Radius { get; }
    }
}