namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Тип магического статуса, влияющего на живого юнита.
    /// </summary>
    public enum StatusType
    {
        /// <summary>
        /// Юнит горит. Каждый тик ему наносится некоторый урон.
        /// </summary>
        Burning,

        /// <summary>
        /// Юнит наносит больше урона, чем обычно. Не применимо к урону, растянутому во времени.
        /// </summary>
        Empowered,

        /// <summary>
        /// Юнит заморожен. Он не может перемещаться и выполнять какие-либо действия.
        /// </summary>
        Frozen,

        /// <summary>
        /// Скорость поворота и перемещения юнита увеличена.
        /// </summary>
        Hastened,

        /// <summary>
        /// Юнит получает меньше урона, чем обычно. Не применимо к урону, растянутому во времени.
        /// </summary>
        Shielded
    }
}