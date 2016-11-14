using Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model;

namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk
{
    /// <summary>
    /// Содержит описание методов искусственного интеллекта волшебника.
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Основной метод стратегии, осуществляющий управление волшебником. Вызывается каждый
        /// тик для каждого волшебника.
        /// </summary>
        /// <param name="self">
        /// Волшебник, которым данный метод будет осуществлять управление.
        /// </param>
        /// <param name="world">
        /// Текущее состояние мира.
        /// </param>
        /// <param name="game">
        /// Различные игровые константы.
        /// </param>
        /// <param name="move">
        /// Результатом работы метода является изменение полей данного объекта.
        /// </param>
        void Move(Wizard self, World world, Game game, Move move);
    }
}