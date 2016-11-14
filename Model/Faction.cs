namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Фракция юнита.
    /// </summary>
    public enum Faction
    {
        /// <summary>
        /// Волшебники, последователи и охранные сооружения Академии.
        /// </summary>
        Academy,

        /// <summary>
        /// Волшебники, последователи и охранные сооружения Отступников.
        /// </summary>
        Renegades,

        /// <summary>
        /// Нейтральные юниты. Не нападют первыми, но при получении урона будут обороняться.
        /// </summary>
        Neutral,

        /// <summary>
        /// Все остальные юниты в игре.
        /// </summary>
        Other
    }
}