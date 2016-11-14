namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Тип дорожки.
    /// </summary>
    public enum LaneType
    {
        /// <summary>
        /// Верхняя. Проходит через левый нижний, левый верхний и правый верхний углы карты.
        /// </summary>
        Top,

        /// <summary>
        /// Центральная. Напрямую соединяет левый нижний и правый верхний углы карты.
        /// </summary>
        Middle,

        /// <summary>
        /// Нижняя. Проходит через левый нижний, правый нижний и правый верхний углы карты.
        /// </summary>
        Bottom
    }
}