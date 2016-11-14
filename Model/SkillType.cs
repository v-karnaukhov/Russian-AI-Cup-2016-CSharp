namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Тип умения. Изучение умений может быть доступно не во всех режимах игры (смотрите документацию к
    /// game.skillsEnabled).
    /// <remarks>
    /// Умения делятся на три категории: активные, пассивные и ауры.
    /// • Активные умения наделяют волшебника способностью использовать определённое действие, недоступное ранее.
    /// 
    /// • Пассивные умения действуют постоянно, улучшая одну из характеристик волшебника на некоторое значение.При
    /// наличии нескольких пассивных умений, влияющих на одну характеристику, учитывается только то, которое даёт
    /// максимальный эффект.
    /// 
    /// • Ауры действуют постоянно, улучшая на некоторое значение одну из характеристик самого волшебника, а также
    /// всех союзных волшебников на расстоянии, не превышающем game.auraSkillRange.При наличии нескольких
    /// аур, влияющих на одну характеристику, учитывается только та, которая даёт максимальный эффект.
    /// </remarks>
    /// </summary>
    public enum SkillType
    {
        /// <summary>
        /// Пассивное умение. Увеличивает максимально возможную дальность полёта магического снаряда,
        /// а также дальность применения магических статусов на game.rangeBonusPerSkillLevel.
        /// </summary>
        RangeBonusPassive1,

        /// <summary>
        /// Аура. Увеличивает максимально возможную дальность полёта магического снаряда, а также
        /// дальность применения магических статусов на game.rangeBonusPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="RangeBonusPassive1"/>.
        /// </remarks>
        /// </summary>
        RangeBonusAura1,

        /// <summary>
        /// Пассивное умение. Увеличивает максимально возможную дальность полёта магического снаряда,
        /// а также дальность применения магических статусов на 2.0 * game.rangeBonusPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="RangeBonusAura1"/>.
        /// </remarks>
        /// </summary>
        RangeBonusPassive2,

        /// <summary>
        /// Аура. Увеличивает максимально возможную дальность полёта магического снаряда, а также
        /// дальность применения магических статусов на 2.0 * game.rangeBonusPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="RangeBonusPassive2"/>.
        /// </remarks>
        /// </summary>
        RangeBonusAura2,

        /// <summary>
        /// Пассивное умение. Убирает задержку на примение действия MAGIC_MISSILE. Общая задержка на
        /// действия волшебника game.wizardActionCooldownTicks всё ещё применяется.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="RangeBonusAura2"/>.
        /// </remarks>
        /// </summary>
        AdvancedMagicMissile,

        /// <summary>
        /// Пассивное умение. Увеличивает урон, наносимый при прямом попадании магического снаряда,
        /// на game.magicalDamageBonusPerSkillLevel.
        /// </summary>
        MagicalDamageBonusPassive1,

        /// <summary>
        /// Аура. Увеличивает урон, наносимый при прямом попадании магического снаряда, на
        /// game.magicalDamageBonusPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MagicalDamageBonusPassive1"/>.
        /// </remarks>
        ///  </summary>
        MagicalDamageBonusAura1,

        /// <summary>
        /// Пассивное умение. Увеличивает урон, наносимый при прямом попадании магического снаряда,
        /// на 2.0 * game.magicalDamageBonusPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MagicalDamageBonusAura1"/>.
        /// </remarks>
        /// </summary>
        MagicalDamageBonusPassive2,

        /// <summary>
        /// Аура. Увеличивает урон, наносимый при прямом попадании магического снаряда, на 2.0 *
        /// game.magicalDamageBonusPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MagicalDamageBonusPassive2"/>.
        /// </remarks>
        /// </summary>
        MagicalDamageBonusAura2,

        /// <summary>
        /// Активное умение. Позволяет волшебнику использовать действие FROST_BOLT.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MagicalDamageBonusAura2"/>.
        /// </remarks>
        /// </summary>
        FrostBolt,

        /// <summary>
        /// Пассивное умение. Увеличивает урон, наносимый при ударе посохом, на
        /// game.staffDamageBonusPerSkillLevel.
        /// </summary>
        StaffDamageBonusPassive1,

        /// <summary>
        /// Аура. Увеличивает урон, наносимый при ударе посохом, на
        /// game.staffDamageBonusPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="StaffDamageBonusPassive1"/>.
        /// </remarks>
        /// </summary>
        StaffDamageBonusAura1,

        /// <summary>
        /// Пассивное умение. Увеличивает урон, наносимый при ударе посохом, на 2.0 *
        /// game.staffDamageBonusPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="StaffDamageBonusAura1"/>.
        /// </remarks>
        /// </summary>
        StaffDamageBonusPassive2,

        /// <summary>
        /// Аура. Увеличивает урон, наносимый при ударе посохом, на 2.0 *
        /// game.staffDamageBonusPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="StaffDamageBonusPassive2"/>.
        /// </remarks>
        /// </summary>
        StaffDamageBonusAura2,

        /// <summary>
        /// Активное умение. Позволяет волшебнику использовать действие FIREBALL.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="StaffDamageBonusAura2"/>.
        /// </remarks>
        /// </summary>
        Fireball,

        /// <summary>
        /// Пассивное умение. Увеличивает скорость перемещения в 1.0 +
        /// game.movementBonusFactorPerSkillLevel раз.
        /// <remarks>
        /// Увеличение скорости от изучения пассивных умений и увеличение скорости в результате действия
        /// аур аддитивны. Таким образом, умения <seealso cref="MovementBonusFactorPassive2"/> и
        /// <seealso cref="MovementBonusFactorAura2"/> суммарно увеличат скорость перемещения в 1.0 + 4.0 *
        /// game.movementBonusFactorPerSkillLevel раз.
        /// </remarks>
        /// </summary>
        MovementBonusFactorPassive1,

        /// <summary>
        /// Аура. Увеличивает скорость перемещения в 1.0 + game.movementBonusFactorPerSkillLevel раз.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MovementBonusFactorPassive1"/>.
        /// </remarks>
        /// </summary>
        MovementBonusFactorAura1,

        /// <summary>
        /// Пассивное умение. Увеличивает скорость перемещения в 1.0 + 2.0 *
        /// game.movementBonusFactorPerSkillLevel раз.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MovementBonusFactorAura1"/>.
        /// </remarks>
        /// </summary>
        MovementBonusFactorPassive2,

        /// <summary>
        /// Аура. Увеличивает скорость перемещения в 1.0 + 2.0 *
        /// game.movementBonusFactorPerSkillLevel раз.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MovementBonusFactorPassive2"/>.
        /// </remarks>
        /// </summary>
        MovementBonusFactorAura2,

        /// <summary>
        /// Активное умение. Позволяет волшебнику использовать действие HASTE.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MovementBonusFactorAura2"/>.
        /// </remarks>
        /// </summary>
        Haste,

        /// <summary>
        /// Пассивное умение. Уменьшает урон, получаемый при прямом попадании магического снаряда, на
        /// game.magicalDamageAbsorptionPerSkillLevel.
        /// </summary>
        MagicalDamageAbsorptionPassive1,

        /// <summary>
        /// Аура. Уменьшает урон, получаемый при прямом попадании магического снаряда, на
        /// game.magicalDamageAbsorptionPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MagicalDamageAbsorptionPassive1"/>.
        /// </remarks>
        /// </summary>
        MagicalDamageAbsorptionAura1,

        /// <summary>
        /// Пассивное умение. Уменьшает урон, получаемый при прямом попадании магического снаряда, на
        /// 2.0 * game.magicalDamageAbsorptionPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MagicalDamageBonusAura1"/>.
        /// </remarks>
        /// </summary>
        MagicalDamageAbsorptionPassive2,

        /// <summary>
        /// Аура. Уменьшает урон, получаемый при прямом попадании магического снаряда, на 2.0 *
        /// game.magicalDamageAbsorptionPerSkillLevel.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MagicalDamageAbsorptionPassive2"/>.
        /// </remarks>
        /// </summary>
        MagicalDamageAbsorptionAura2,

        /// <summary>
        /// Активное умение. Позволяет волшебнику использовать действие SHIELD.
        /// <remarks>
        /// Требуется предварительно изучить умение <see cref="MagicalDamageAbsorptionAura2"/>.
        /// </remarks>
        /// </summary>
        Shield
    }
}