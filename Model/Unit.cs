using System;

namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Базовый класс для определения объектов («юнитов») на игровом поле.
    /// </summary>
    public abstract class Unit
    {
        protected Unit(long id, double x, double y, double speedX, double speedY, double angle, Faction faction)
        {
            Id = id;
            X = x;
            Y = y;
            SpeedX = speedX;
            SpeedY = speedY;
            Angle = angle;
            Faction = faction;
        }

        /// <summary>
        /// Уникальный идентификатор объекта.
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// X-координата центра объекта. Ось абсцисс направлена слева направо.
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Y-координата центра объекта. Ось абсцисс направлена слева направо.
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// X-составляющая скорости объекта. Ось абсцисс направлена слева направо.
        /// <remarks>
        /// Для юнитов, способных мгновенно менять свою скорость, возвращается значение перемещения
        /// за последний тик.
        /// </remarks>
        /// </summary>
        public double SpeedX { get; }

        /// <summary>
        /// Y-составляющая скорости объекта. Ось ординат направлена сверху вниз.
        /// <remarks>
        /// Для юнитов, способных мгновенно менять свою скорость, возвращается значение перемещения
        /// за последний тик.
        /// </remarks>
        /// </summary>
        public double SpeedY { get; }

        /// <summary>
        /// Угол поворота объекта в радианах. Нулевой угол соответствует
        /// направлению оси абсцисс.Положительные значения соответствуют повороту по часовой стрелке.
        /// </summary>
        public double Angle { get; }

        /// <summary>
        /// Фракция, к которой принадлежит данный юнит.
        /// </summary>
        public Faction Faction { get; }

        /// <summary>
        /// Получает ориентированный угол [-PI, PI] между направлением данного объекта и
        /// вектором из центра данного объекта к указанной точке.
        /// </summary>
        /// <param name="x">
        /// X-координата точки.
        /// </param>
        /// <param name="y">
        /// Y-координата точки.
        /// </param>
        /// <returns>
        /// Возвращает ориентированный угол.
        /// </returns>
        public double GetAngleTo(double x, double y)
        {
            double absoluteAngleTo = Math.Atan2(y - Y, x - X);
            double relativeAngleTo = absoluteAngleTo - Angle;

            while (relativeAngleTo > Math.PI)
            {
                relativeAngleTo -= 2.0D * Math.PI;
            }

            while (relativeAngleTo < -Math.PI)
            {
                relativeAngleTo += 2.0D * Math.PI;
            }

            return relativeAngleTo;
        }

        /// <summary>
        /// Получает ориентированный угол [-PI, PI] между направлением данного объекта и
        /// вектором из центра данного объекта к центру указанного объекта.
        /// </summary>
        /// <param name="unit">
        /// Объект, к центру которого необходимо определить угол.
        /// </param>
        /// <returns>
        /// Возвращает ориентированный угол.
        /// </returns>
        public double GetAngleTo(Unit unit)
        {
            return GetAngleTo(unit.X, unit.Y);
        }

        /// <summary>
        /// Получает расстояние до точки от центра данного объекта.
        /// </summary>
        /// <param name="x">
        /// X-координата точки.
        /// </param>
        /// <param name="y">
        /// Y-координата точки.
        /// </param>
        /// <returns>
        /// Возвращает расстояние до точки от центра данного объекта.
        /// </returns>
        public double GetDistanceTo(double x, double y)
        {
            double xRange = x - X;
            double yRange = y - Y;
            return Math.Sqrt(xRange * xRange + yRange * yRange);
        }

        /// <summary>
        /// Получает расстояние от центра данного объекта до центра указанного объекта.
        /// </summary>
        /// <param name="unit">
        /// Объект, до центра которого необходимо определить расстояние.
        /// </param>
        /// <returns>
        /// Возвращает расстояние от центра данного объекта до центра указанного объекта.
        /// </returns>
        public double GetDistanceTo(Unit unit)
        {
            return GetDistanceTo(unit.X, unit.Y);
        }
    }
}