namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Тип снаряда.
    /// </summary>
    public enum ProjectileType
    {
        /// <summary>
        /// Магическая ракета.
        /// </summary>
        /// <remarks>
        /// Небольшой сгусток чистой энергии, который наносит урон при прямом попадании.
        /// </remarks>
        MagicMissile,

        /// <summary>
        /// Ледяная стрела.
        /// </summary> 
        /// <remarks>
        /// Наносит урон при прямом попадании, а также замораживает цель на
        /// game.frozenDurationTicks тиков. Замороженная цель не может перемещаться и совершать
        /// какие-либо действия.
        /// </remarks>
        FrostBolt,

        /// <summary>
        /// Огненный шар.
        /// </summary>
        /// <remarks>
        /// Взрывается при достижении максимальной дальности полёта или при
        /// столкновении с живым объектом. Наносит урон всем живым объектам, если расстояние от
        /// центра шара до центра объекта не превышает game.fireballExplosionMinDamageRange +
        /// livingUnit.radius, а также поджигает их (BURNING). Мгновенный урон уменьшается по мере
        /// удаления от эпицентра взрыва.
        /// </remarks>
        Fireball,

        /// <summary>
        /// Дротик.
        /// </summary>
        /// <remarks>
        /// Заострённый предмет, летящий на большой скорости. Наносит урон при прямом
        /// попадании.
        /// </remarks>
        Dart
    }
}