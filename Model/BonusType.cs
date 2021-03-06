﻿namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Тип бонуса.
    /// </summary>
    /// <remarks>
    /// В дополнение к основному эффекту каждый подобранный бонус даёт игроку game.bonusScoreAmount баллов, а
    /// волшебник получает такое же количество опыта.
    /// </remarks>
    public enum BonusType
    {
        /// <summary>
        /// На некоторое время значительно увеличивает урон, наносимый волшебником при ударах посохом
        /// и попаданиях магических снарядов в цель.
        /// </summary>
        Empower,

        /// <summary>
        /// Значительно ускоряет перемещение волшебника.
        /// </summary>
        /// <remarks>
        /// Аналогично действию одноимённого заклинания, но длительность статуса выше.
        /// </remarks>
        Haste,

        /// <summary>
        /// Уменьшает урон, получаемый волшебником от прямых попаданий магических снарядов.
        /// </summary>
        /// <remarks>
        /// Аналогично действию одноимённого заклинания, но длительность статуса выше.
        /// </remarks>
        Shield
    }
}