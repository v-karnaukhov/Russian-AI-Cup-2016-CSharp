using System;

namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Предоставляет доступ к различным игровым константам.
    /// </summary>
    public class Game
    {
        private readonly int[] _levelUpXpValues;

        public Game(long randomSeed, int tickCount, double mapSize, bool isSkillsEnabled, bool isRawMessagesEnabled,
                double friendlyFireDamageFactor, double buildingDamageScoreFactor,
                double buildingEliminationScoreFactor, double minionDamageScoreFactor,
                double minionEliminationScoreFactor, double wizardDamageScoreFactor,
                double wizardEliminationScoreFactor, double teamWorkingScoreFactor, int victoryScore,
                double scoreGainRange, int rawMessageMaxLength, double rawMessageTransmissionSpeed, double wizardRadius,
                double wizardCastRange, double wizardVisionRange, double wizardForwardSpeed, double wizardBackwardSpeed,
                double wizardStrafeSpeed, int wizardBaseLife, int wizardLifeGrowthPerLevel, int wizardBaseMana,
                int wizardManaGrowthPerLevel, double wizardBaseLifeRegeneration,
                double wizardLifeRegenerationGrowthPerLevel, double wizardBaseManaRegeneration,
                double wizardManaRegenerationGrowthPerLevel, double wizardMaxTurnAngle,
                int wizardMaxResurrectionDelayTicks, int wizardMinResurrectionDelayTicks, int wizardActionCooldownTicks,
                int staffCooldownTicks, int magicMissileCooldownTicks, int frostBoltCooldownTicks,
                int fireballCooldownTicks, int hasteCooldownTicks, int shieldCooldownTicks, int magicMissileManacost,
                int frostBoltManacost, int fireballManacost, int hasteManacost, int shieldManacost, int staffDamage,
                double staffSector, double staffRange, int[] levelUpXpValues, double minionRadius,
                double minionVisionRange, double minionSpeed, double minionMaxTurnAngle, int minionLife,
                int factionMinionAppearanceIntervalTicks, int orcWoodcutterActionCooldownTicks, int orcWoodcutterDamage,
                double orcWoodcutterAttackSector, double orcWoodcutterAttackRange,
                int fetishBlowdartActionCooldownTicks, double fetishBlowdartAttackRange,
                double fetishBlowdartAttackSector, double bonusRadius, int bonusAppearanceIntervalTicks,
                int bonusScoreAmount, double dartRadius, double dartSpeed, int dartDirectDamage,
                double magicMissileRadius, double magicMissileSpeed, int magicMissileDirectDamage,
                double frostBoltRadius, double frostBoltSpeed, int frostBoltDirectDamage, double fireballRadius,
                double fireballSpeed, double fireballExplosionMaxDamageRange, double fireballExplosionMinDamageRange,
                int fireballExplosionMaxDamage, int fireballExplosionMinDamage, double guardianTowerRadius,
                double guardianTowerVisionRange, double guardianTowerLife, double guardianTowerAttackRange,
                int guardianTowerDamage, int guardianTowerCooldownTicks, double factionBaseRadius,
                double factionBaseVisionRange, double factionBaseLife, double factionBaseAttackRange,
                int factionBaseDamage, int factionBaseCooldownTicks, int burningDurationTicks, int burningSummaryDamage,
                int empoweredDurationTicks, double empoweredDamageFactor, int frozenDurationTicks,
                int hastenedDurationTicks, double hastenedBonusDurationFactor, double hastenedMovementBonusFactor,
                double hastenedRotationBonusFactor, int shieldedDurationTicks, double shieldedBonusDurationFactor,
                double shieldedDirectDamageAbsorptionFactor, double auraSkillRange, double rangeBonusPerSkillLevel,
                int magicalDamageBonusPerSkillLevel, int staffDamageBonusPerSkillLevel,
                double movementBonusFactorPerSkillLevel, int magicalDamageAbsorptionPerSkillLevel)
        {
            RandomSeed = randomSeed;
            TickCount = tickCount;
            MapSize = mapSize;
            IsSkillsEnabled = isSkillsEnabled;
            IsRawMessagesEnabled = isRawMessagesEnabled;
            FriendlyFireDamageFactor = friendlyFireDamageFactor;
            BuildingDamageScoreFactor = buildingDamageScoreFactor;
            BuildingEliminationScoreFactor = buildingEliminationScoreFactor;
            MinionDamageScoreFactor = minionDamageScoreFactor;
            MinionEliminationScoreFactor = minionEliminationScoreFactor;
            WizardDamageScoreFactor = wizardDamageScoreFactor;
            WizardEliminationScoreFactor = wizardEliminationScoreFactor;
            TeamWorkingScoreFactor = teamWorkingScoreFactor;
            VictoryScore = victoryScore;
            ScoreGainRange = scoreGainRange;
            RawMessageMaxLength = rawMessageMaxLength;
            RawMessageTransmissionSpeed = rawMessageTransmissionSpeed;
            WizardRadius = wizardRadius;
            WizardCastRange = wizardCastRange;
            WizardVisionRange = wizardVisionRange;
            WizardForwardSpeed = wizardForwardSpeed;
            WizardBackwardSpeed = wizardBackwardSpeed;
            WizardStrafeSpeed = wizardStrafeSpeed;
            WizardBaseLife = wizardBaseLife;
            WizardLifeGrowthPerLevel = wizardLifeGrowthPerLevel;
            WizardBaseMana = wizardBaseMana;
            WizardManaGrowthPerLevel = wizardManaGrowthPerLevel;
            WizardBaseLifeRegeneration = wizardBaseLifeRegeneration;
            WizardLifeRegenerationGrowthPerLevel = wizardLifeRegenerationGrowthPerLevel;
            WizardBaseManaRegeneration = wizardBaseManaRegeneration;
            WizardManaRegenerationGrowthPerLevel = wizardManaRegenerationGrowthPerLevel;
            WizardMaxTurnAngle = wizardMaxTurnAngle;
            WizardMaxResurrectionDelayTicks = wizardMaxResurrectionDelayTicks;
            WizardMinResurrectionDelayTicks = wizardMinResurrectionDelayTicks;
            WizardActionCooldownTicks = wizardActionCooldownTicks;
            StaffCooldownTicks = staffCooldownTicks;
            MagicMissileCooldownTicks = magicMissileCooldownTicks;
            FrostBoltCooldownTicks = frostBoltCooldownTicks;
            FireballCooldownTicks = fireballCooldownTicks;
            HasteCooldownTicks = hasteCooldownTicks;
            ShieldCooldownTicks = shieldCooldownTicks;
            MagicMissileManacost = magicMissileManacost;
            FrostBoltManacost = frostBoltManacost;
            FireballManacost = fireballManacost;
            HasteManacost = hasteManacost;
            ShieldManacost = shieldManacost;
            StaffDamage = staffDamage;
            StaffSector = staffSector;
            StaffRange = staffRange;

            _levelUpXpValues = new int[levelUpXpValues.Length];
            Array.Copy(levelUpXpValues, _levelUpXpValues, levelUpXpValues.Length);

            MinionRadius = minionRadius;
            MinionVisionRange = minionVisionRange;
            MinionSpeed = minionSpeed;
            MinionMaxTurnAngle = minionMaxTurnAngle;
            MinionLife = minionLife;
            FactionMinionAppearanceIntervalTicks = factionMinionAppearanceIntervalTicks;
            OrcWoodcutterActionCooldownTicks = orcWoodcutterActionCooldownTicks;
            OrcWoodcutterDamage = orcWoodcutterDamage;
            OrcWoodcutterAttackSector = orcWoodcutterAttackSector;
            OrcWoodcutterAttackRange = orcWoodcutterAttackRange;
            FetishBlowdartActionCooldownTicks = fetishBlowdartActionCooldownTicks;
            FetishBlowdartAttackRange = fetishBlowdartAttackRange;
            FetishBlowdartAttackSector = fetishBlowdartAttackSector;
            BonusRadius = bonusRadius;
            BonusAppearanceIntervalTicks = bonusAppearanceIntervalTicks;
            BonusScoreAmount = bonusScoreAmount;
            DartRadius = dartRadius;
            DartSpeed = dartSpeed;
            DartDirectDamage = dartDirectDamage;
            MagicMissileRadius = magicMissileRadius;
            MagicMissileSpeed = magicMissileSpeed;
            MagicMissileDirectDamage = magicMissileDirectDamage;
            FrostBoltRadius = frostBoltRadius;
            FrostBoltSpeed = frostBoltSpeed;
            FrostBoltDirectDamage = frostBoltDirectDamage;
            FireballRadius = fireballRadius;
            FireballSpeed = fireballSpeed;
            FireballExplosionMaxDamageRange = fireballExplosionMaxDamageRange;
            FireballExplosionMinDamageRange = fireballExplosionMinDamageRange;
            FireballExplosionMaxDamage = fireballExplosionMaxDamage;
            FireballExplosionMinDamage = fireballExplosionMinDamage;
            GuardianTowerRadius = guardianTowerRadius;
            GuardianTowerVisionRange = guardianTowerVisionRange;
            GuardianTowerLife = guardianTowerLife;
            GuardianTowerAttackRange = guardianTowerAttackRange;
            GuardianTowerDamage = guardianTowerDamage;
            GuardianTowerCooldownTicks = guardianTowerCooldownTicks;
            FactionBaseRadius = factionBaseRadius;
            FactionBaseVisionRange = factionBaseVisionRange;
            FactionBaseLife = factionBaseLife;
            FactionBaseAttackRange = factionBaseAttackRange;
            FactionBaseDamage = factionBaseDamage;
            FactionBaseCooldownTicks = factionBaseCooldownTicks;
            BurningDurationTicks = burningDurationTicks;
            BurningSummaryDamage = burningSummaryDamage;
            EmpoweredDurationTicks = empoweredDurationTicks;
            EmpoweredDamageFactor = empoweredDamageFactor;
            FrozenDurationTicks = frozenDurationTicks;
            HastenedDurationTicks = hastenedDurationTicks;
            HastenedBonusDurationFactor = hastenedBonusDurationFactor;
            HastenedMovementBonusFactor = hastenedMovementBonusFactor;
            HastenedRotationBonusFactor = hastenedRotationBonusFactor;
            ShieldedDurationTicks = shieldedDurationTicks;
            ShieldedBonusDurationFactor = shieldedBonusDurationFactor;
            ShieldedDirectDamageAbsorptionFactor = shieldedDirectDamageAbsorptionFactor;
            AuraSkillRange = auraSkillRange;
            RangeBonusPerSkillLevel = rangeBonusPerSkillLevel;
            MagicalDamageBonusPerSkillLevel = magicalDamageBonusPerSkillLevel;
            StaffDamageBonusPerSkillLevel = staffDamageBonusPerSkillLevel;
            MovementBonusFactorPerSkillLevel = movementBonusFactorPerSkillLevel;
            MagicalDamageAbsorptionPerSkillLevel = magicalDamageAbsorptionPerSkillLevel;
        }

        /// <summary>
        /// Некоторое число, которое ваша стратегия может использовать для
        /// инициализации генератора случайных чисел.Данное значение имеет рекомендательный характер,
        /// однако позволит более точно воспроизводить прошедшие игры.
        /// </summary>
        public long RandomSeed { get; }

        /// <summary>
        /// Базовая длительность игры в тиках. Реальная длительность может
        /// отличаться от этого значения в меньшую сторону.Эквивалентно world.tickCount.
        /// </summary>
        public int TickCount { get; }

        /// <summary>
        /// Размер (ширина и высота) карты.
        /// </summary>
        public double MapSize { get; }

        /// <summary>
        /// Возвращает true, если и только если верховные волшебники в данной игре могут
        /// передавать низкоуровневые сообщения другим волшебникам своей фракции.
        /// </summary>
        public bool IsSkillsEnabled { get; }

        /// <summary>
        /// Возвращает true, если и только если в данной игре волшебники могут повышать свой
        /// уровень(накапливая опыт) и изучать новые умения.
        /// </summary>
        public bool IsRawMessagesEnabled { get; }

        /// <summary>
        /// Коэффициент урона, наносимого волшебниками одной фракции друг другу
        /// в результате дружественного огня.
        /// </summary>
        /// <remarks>
        /// Значение зависит от режима игры, но не может выходить за границы интервала от 0.0 до 1.0.
        /// Вне зависимости от режима игры, волшебники не могут наносить урон союзным миньонам и
        /// структурам.
        /// </remarks>
        public double FriendlyFireDamageFactor { get; }

        /// <summary>
        /// Коэффициент опыта, получаемого волшебником при нанесении урона
        /// строениям противоположной фракции.
        /// </summary>
        public double BuildingDamageScoreFactor { get; }

        /// <summary>
        /// Коэффициент опыта, получаемого волшебником за разрушение строения
        /// противоположной фракции.
        /// </summary>
        /// <remarks>
        /// Применяется к максимальному количеству жизненной энергии строения.
        /// </remarks>
        public double BuildingEliminationScoreFactor { get; }

        /// <summary>
        /// Коэффициент опыта, получаемого волшебником при нанесении урона
        /// миньонам другой фракции.
        /// </summary>
        public double MinionDamageScoreFactor { get; }

        /// <summary>
        /// Коэффициент опыта, получаемого волшебником за уничтожение миньона
        /// другой фракции.
        /// </summary>
        /// <remarks>
        /// Применяется к максимальному количеству жизненной энергии миньона.
        /// </remarks>
        public double MinionEliminationScoreFactor { get; }

        /// <summary>
        /// Коэффициент опыта, получаемого волшебником при нанесении урона
        /// волшебникам противоположной фракции.
        /// </summary>
        public double WizardDamageScoreFactor { get; }

        /// <summary>
        /// Коэффициент опыта, получаемого волшебником за разрушение телесной
        /// оболочки волшебника противоположной фракции.
        /// </summary>
        /// <remarks>
        /// Применяется к максимальному количеству жизненной энергии волшебника.
        /// </remarks>
        public double WizardEliminationScoreFactor { get; }

        /// <summary>
        /// Мультипликатор опыта, применяемый в случае уничтожения юнита
        /// противника при участии двух или более волшебников.
        /// </summary>
        /// <remarks>
        /// После применения мультипликатора количество опыта округляется вниз до ближайшего целого значения.
        /// </remarks>
        public double TeamWorkingScoreFactor { get; }

        /// <summary>
        /// Количество баллов, получаемых всеми игроками фракции в случае победы — 
        /// разрушения базы противоположной фракции.
        /// </summary>
        public int VictoryScore { get; }

        /// <summary>
        /// Максимальное расстояние, на котором волшебник получает опыт при
        /// уничтожении союзником юнита другой фракции.
        /// </summary>
        /// <remarks>
        /// При уничтожении противника опыт равномерно распределяется между всеми волшебниками,
        /// находящимися на расстоянии от цели, на превышающем scoreGainRange, а также юнитом,
        /// нанёсшим урон, если это тоже волшебник.
        /// При нанесении противнику урона, не приводящему к уничтожению юнита, данный параметр не
        /// применяется, а опыт полностью достаётся атакующему волшебнику.В случае атаки миньона или
        /// строения опыт не достаётся никому.
        /// Учитывается расстояние между центрами юнитов.
        /// </remarks>
        public double ScoreGainRange { get; }

        /// <summary>
        /// Максимально возможную длину низкоуровневого сообщения.
        /// </summary>
        /// <remarks>
        /// Сообщения, длина которых превышает указанное значение, будут проигнорированы.
        /// </remarks>
        public int RawMessageMaxLength { get; }

        /// <summary>
        /// Скорость отправки сообщения.
        /// </summary>
        /// <remarks>
        /// Если текстовая часть сообщения пуста, то адресат получит его уже в следующий игровой тик. В
        /// противном случае, момент получения сообщения будет отложен на
        /// ceil(message.rawMessage.length / rawMessageTransmissionSpeed) игровых тиков.
        /// </remarks>
        public double RawMessageTransmissionSpeed { get; }

        /// <summary>
        /// Радиус волшебника.
        /// </summary>
        public double WizardRadius { get; }

        /// <summary>
        /// Базовая дальность заклинаний волшебника.
        /// </summary>
        /// <remarks>
        /// Эффективная дальность (wizard.castRange) может быть выше в результате действия некоторых
        /// аур и/или изучения волшебником некоторых умений.
        /// </remarks>
        public double WizardCastRange { get; }

        /// <summary>
        /// Максимальное расстояние (от центра до центра), на котором волшебник
        /// обнаруживает другие объекты.
        /// </summary>
        public double WizardVisionRange { get; }

        /// <summary>
        /// Базовое ограничение скорости волшебника при движении вперёд.
        /// </summary>
        /// <remarks>
        /// Эффективное ограничение может быть выше в результате действия некоторых аур и/или
        /// изучения волшебником некоторых умений, а также в результате действия статуса HASTENED.
        /// </remarks>
        public double WizardForwardSpeed { get; }

        /// <summary>
        /// Базовое ограничение скорости волшебника при движении назад.
        /// </summary>
        /// <remarks>
        /// Эффективное ограничение может быть выше в результате действия некоторых аур и/или
        /// изучения волшебником некоторых умений, а также в результате действия статуса HASTENED.
        /// </remarks>
        public double WizardBackwardSpeed { get; }

        /// <summary>
        /// Базовое ограничение скорости волшебника при движении боком.
        /// </summary>
        /// <remarks>
        /// Эффективное ограничение может быть выше в результате действия некоторых аур и/или
        /// изучения волшебником некоторых умений, а также в результате действия статуса HASTENED.
        /// </remarks>
        public double WizardStrafeSpeed { get; }

        /// <summary>
        /// Максимальное значение жизненной энергии волшебника на уровне 0.
        /// </summary>
        public int WizardBaseLife { get; }

        /// <summary>
        /// Прирост жизненной энергии волшебника за уровень.
        /// </summary>
        public int WizardLifeGrowthPerLevel { get; }

        /// <summary>
        /// Максимальное значение магической энергии волшебника на уровне 0.
        /// </summary>
        public int WizardBaseMana { get; }

        /// <summary>
        /// Прирост магической энергии волшебника за уровень.
        /// </summary>
        public int WizardManaGrowthPerLevel { get; }

        /// <summary>
        /// Количество жизненной энергии, которое волшебник уровня 0
        /// восстанавливает за один тик.
        /// </summary>
        public double WizardBaseLifeRegeneration { get; }

        /// <summary>
        /// Прирост скорости регенерации жизненной энергии волшебника за один уровень.
        /// </summary>
        public double WizardLifeRegenerationGrowthPerLevel { get; }

        /// <summary>
        /// Количество магической энергии, которое волшебник уровня 0
        /// восстанавливает за один тик.
        /// </summary>
        public double WizardBaseManaRegeneration { get; }

        /// <summary>
        /// Прирост скорости регенерации магической энергии волшебника за один уровень.
        /// </summary>
        public double WizardManaRegenerationGrowthPerLevel { get; }

        /// <summary>
        /// Базовое ограничение на изменение угла поворота волшебника за один тик.
        /// </summary>
        /// <remarks>
        /// Эффективное ограничение может быть выше в 1.0 + hastenedRotationBonusFactor раз в
        /// результате действия статуса HASTENED.
        /// </remarks>
        public double WizardMaxTurnAngle { get; }

        /// <summary>
        /// Максимально возможная задержка возрождения волшебника после
        /// смерти его телесной оболочки.
        /// </summary>
        /// <remarks>
        /// Если волшебник погибает сразу после своего возрождения, то он будет автоматически воскрешён
        /// на своей начальной позиции(или недалеко от неё, если это невозможно) через
        /// wizardMaxResurrectionDelayTicks тиков.Каждый игровой тик жизни волшебника
        /// уменьшшает эту задержку на единицу.Задержка возрождения не может стать меньше, чем
        /// wizardMinResurrectionDelayTicks.
        /// </remarks>
        public int WizardMaxResurrectionDelayTicks { get; }

        /// <summary>
        /// Минимально возможная задержка возрождения волшебника после смерти
        /// его телесной оболочки.
        /// </summary>
        /// <remarks>
        /// Если волшебник погибает сразу после своего возрождения, то он будет автоматически воскрешён
        /// на своей начальной позиции(или недалеко от неё, если это невозможно) через
        /// wizardMaxResurrectionDelayTicks тиков.Каждый игровой тик жизни волшебника
        /// уменьшшает эту задержку на единицу.Задержка возрождения не может стать меньше, чем
        /// wizardMinResurrectionDelayTicks.
        /// </remarks>
        public int WizardMinResurrectionDelayTicks { get; }

        /// <summary>
        /// Минимально возможная задержка между любыми двумя последовательными действиями волшебника.
        /// </summary>
        public int WizardActionCooldownTicks { get; }

        /// <summary>
        /// Минимально возможная задержка между двумя последовательными ударами посохом.
        /// </summary>
        public int StaffCooldownTicks { get; }

        /// <summary>
        /// Минимально возможную задержку между двумя последовательными
        /// заклинаниями «Магическая ракета».
        /// </summary>
        public int MagicMissileCooldownTicks { get; }

        /// <summary>
        /// Минимально возможную задержку между двумя последовательными
        /// заклинаниями «Ледяная стрела».
        /// </summary>
        public int FrostBoltCooldownTicks { get; }

        /// <summary>
        /// Минимально возможная задержка между двумя последовательными
        /// заклинаниями «Огненный шар».
        /// </summary>
        public int FireballCooldownTicks { get; }

        /// <summary>
        /// Минимально возможную задержку между двумя последовательными
        /// заклинаниями «Ускорение».
        /// </summary>
        public int HasteCooldownTicks { get; }

        /// <summary>
        /// Минимально возможная задержка между двумя последовательными
        /// заклинаниями «Щит».
        /// </summary>
        public int ShieldCooldownTicks { get; }

        /// <summary>
        /// Количество магической энергии, требуемой для заклинания «Магическая ракета».
        /// </summary>
        public int MagicMissileManacost { get; }

        /// <summary>
        /// Количество магической энергии, требуемой для заклинания «Ледяная стрела».
        /// </summary>
        public int FrostBoltManacost { get; }

        /// <summary>
        /// Магической энергии, требуемой для заклинания «Огненный шар».
        /// </summary>
        public int FireballManacost { get; }

        /// <summary>
        /// Количество магической энергии, требуемой для заклинания «Ускорение».
        /// </summary>
        public int HasteManacost { get; }

        /// <summary>
        /// Количество магической энергии, требуемой для заклинания «Щит».
        /// </summary>
        public int ShieldManacost { get; }

        /// <summary>
        /// Базовый урон удара посохом.
        /// </summary>
        /// <remarks>
        /// Эффективный урон может быть выше в результате действия некоторых аур и/или изучения
        /// волшебником некоторых умений.
        /// </remarks>
        public int StaffDamage { get; }

        /// <summary>
        /// Сектор действия посоха волшебника.
        /// </summary>
        /// <remarks>
        /// Атака посохом поражает все живые объекты в секторе от -staffSector / 2.0 до 
        /// staffSector / 2.0. Этим же интервалом ограничены относительный угол снаряда, а также зона применения
        /// магического статуса.
        /// </remarks>
        public double StaffSector { get; }

        /// <summary>
        /// Дальность действия посоха волшебника.
        /// </summary>
        /// <remarks>
        /// Атака посохом поражает все живые объекты, для каждого из которых верно, что расстояние от
        /// его центра до центра волшебника не превышает значение staffRange + livingUnit.radius.
        /// </remarks>
        public double StaffRange { get; }

        /// <summary>
        /// Последовательность неотрицательных целых чисел.
        /// </summary>
        /// <remarks>
        /// Количество чисел равно количеству уровней, которые волшебник может получить в данном
        /// режиме игры.Значение с индексом N определяет количество опыта, которое необходимо набрать
        /// волшебнику уровня N для получения следующего уровня. Таким образом, количество опыта,
        /// необходимое волшебнику начального уровня для получения уровня N, равно сумме первых N
        /// элементов.
        /// </remarks>
        public int[] LevelUpXpValues
        {
            get
            {
                if (_levelUpXpValues == null)
                {
                    return null;
                }

                int[] levelUpXpValues = new int[_levelUpXpValues.Length];
                Array.Copy(_levelUpXpValues, levelUpXpValues, _levelUpXpValues.Length);
                return levelUpXpValues;
            }
        }

        /// <summary>
        /// Радиус миньона.
        /// </summary>
        public double MinionRadius { get; }

        /// <summary>
        /// Максимальное расстояние (от центра до центра), на котором миньон
        /// обнаруживает другие объекты.
        /// </summary>
        public double MinionVisionRange { get; }

        /// <summary>
        /// Cкорость миньона при движении вперёд.
        /// </summary>
        /// <remarks>
        /// Миньонам недоступно использование других видов движения, а также перемещение со
        /// скоростью, отличной от указанной.
        /// </remarks>
        public double MinionSpeed { get; }

        /// <summary>
        /// Ограничение на изменение угла поворота миньона за один тик.
        /// </summary>
        public double MinionMaxTurnAngle { get; }

        /// <summary>
        /// Максимальное значение жизненной энергии миньона.
        /// </summary>
        public int MinionLife { get; }

        /// <summary>
        /// Интервал, с которым появляются миньоны двух противостоящих фракций
        /// (ACADEMY и RENEGADES).
        /// </summary>
        /// <remarks>
        /// Миньоны каждой из этих фракций появляются тремя группами (по одной на дорожку) недалеко
        /// от своей базы.Группа состоит и трёх орков и одного фетиша.Сразу после появления миньоны
        /// начинают продвижение по своей дорожке в сторону базы противоположной фракции, при этом
        /// атакуя всех противников на своём пути.
        /// </remarks>
        public int FactionMinionAppearanceIntervalTicks { get; }

        /// <summary>
        /// Минимально возможная задержка между двумя последовательными
        /// атаками орка-дровосека.
        /// </summary>
        public int OrcWoodcutterActionCooldownTicks { get; }

        /// <summary>
        /// Урон одной атаки орка-дровосека.
        /// </summary>
        public int OrcWoodcutterDamage { get; }

        /// <summary>
        /// Возвращает сектор действия топора орка.
        /// </summary>
        /// <remarks>
        /// Атака топором поражает все живые объекты в секторе от -orcWoodcutterAttackSector / 2.0
        /// до orcWoodcutterAttackSector / 2.0.
        /// </remarks>
        public double OrcWoodcutterAttackSector { get; }

        /// <summary>
        /// Дальность действия топора орка.
        /// </summary>
        /// <remarks>
        /// Атака топором поражает все живые объекты, для каждого из которых верно, что расстояние от
        /// его центра до центра орка-дровосека не превышает значение 
        /// orcWoodcutterAttackRange +  livingUnit.radius.
        /// </remarks>
        public double OrcWoodcutterAttackRange { get; }

        /// <summary>
        /// Минимально возможная задержка между двумя последовательными
        /// атаками фетиша.
        /// </summary>
        public int FetishBlowdartActionCooldownTicks { get; }

        /// <summary>
        /// Дальность полёта дротика, выпущенного фетишем.
        /// </summary>
        public double FetishBlowdartAttackRange { get; }

        /// <summary>
        /// Сектор метания дротика фетишем.
        /// </summary>
        /// <remarks>
        /// Угол полёта дротика относительно направления фетиша ограничен интервалом от
        /// -fetishBlowdartAttackSector / 2.0 до fetishBlowdartAttackSector / 2.0.
        /// </remarks>
        public double FetishBlowdartAttackSector { get; }

        /// <summary>
        /// Радиус бонуса.
        /// </summary>
        public double BonusRadius { get; }

        /// <summary>
        /// Интервал появления бонусов.
        /// </summary>
        /// <remarks>
        /// Каждый раз по прошествии указанного интервала симулятор игры создаёт до двух бонусов в
        /// точках(mapSize * 0.3, mapSize * 0.3) и(mapSize * 0.7, mapSize * 0.7). Если любая часть
        /// области появления бонуса уже занята волшебником или другим бонусом, то создание бонуса
        /// будет отложено до окончания очередного интервала.
        /// </remarks>
        public int BonusAppearanceIntervalTicks { get; }

        /// <summary>
        /// Возвращает количество баллов, начисляемых игроку, волшебник которого подробрал бонус.
        /// </summary>
        /// <remarks>
        /// Сам волшебник получает такое же количество опыта.
        /// </remarks>
        public int BonusScoreAmount { get; }

        /// <summary>
        /// Радиус дротика.
        /// </summary>
        public double DartRadius { get; }

        /// <summary>
        /// Скорость полёта дротика.
        /// </summary>
        public double DartSpeed { get; }

        /// <summary>
        /// Урон дротика.
        /// </summary>
        public int DartDirectDamage { get; }

        /// <summary>
        /// Радиус «Магической ракеты».
        /// </summary>
        public double MagicMissileRadius { get; }

        /// <summary>
        /// Скорость полёта «Магической ракеты».
        /// </summary>
        public double MagicMissileSpeed { get; }

        /// <summary>
        /// Урон «Магической ракеты».
        /// </summary>
        public int MagicMissileDirectDamage { get; }

        /// <summary>
        /// Радиус «Ледяной стрелы».
        /// </summary>
        public double FrostBoltRadius { get; }

        /// <summary>
        /// Скорость полёта «Ледяной стрелы».
        /// </summary>
        public double FrostBoltSpeed { get; }

        /// <summary>
        /// Урон «Ледяной стрелы».
        /// </summary>
        public int FrostBoltDirectDamage { get; }

        /// <summary>
        /// Радиус «Огненного шара».
        /// </summary>
        public double FireballRadius { get; }

        /// <summary>
        /// Скорость полёта «Огненного шара».
        /// </summary>
        public double FireballSpeed { get; }

        /// <summary>
        /// Радиус области, в которой живые юниты получают максимальный урон от
        /// взрыва «Огненного шара».
        /// <seealso cref="FireballExplosionMaxDamage"/>
        /// </summary>
        public double FireballExplosionMaxDamageRange { get; }

        /// <summary>
        /// Радиус области, в которой живые юниты получают какой-либо урон от
        /// взрыва «Огненного шара».
        /// </summary>
        /// <seealso cref="FireballExplosionMaxDamage"/>
        public double FireballExplosionMinDamageRange { get; }

        /// <summary>
        /// Урон «Огненного шара» в эпицентре взрыва.
        /// </summary>
        /// <remarks>
        /// Живой юнит получает fireballExplosionMaxDamage единиц урона, если расстояние от центра
        /// взрыва до ближайшей точки этого юнита не превышает fireballExplosionMaxDamageRange.По
        /// мере увеличения расстояния до fireballExplosionMinDamageRange, урон «Огненного шара»
        /// равномерно снижается и достигает fireballExplosionMinDamage.Если расстояние от центра
        /// взрыва до ближайшей точки живого юнита превышает fireballExplosionMinDamageRange, то
        /// урон ему не наносится.
        /// Если живой юнит получил какой-либо урон от взрыва «Огненного шара», то он загорается
        /// (BURNING).
        /// </remarks>
        public int FireballExplosionMaxDamage { get; }

        /// <summary>
        /// Урон «Огненного шара» на периферии взрыва.
        /// <seealso cref="FireballExplosionMaxDamage"/>
        /// </summary>
        public int FireballExplosionMinDamage { get; }

        /// <summary>
        /// Радиус охранной башни.
        /// </summary>
        public double GuardianTowerRadius { get; }

        /// <summary>
        /// Максимальное расстояние (от центра до центра), на котором охранная
        /// башня обнаруживает другие объекты.
        /// </summary>
        public double GuardianTowerVisionRange { get; }

        /// <summary>
        /// Начальное значение жизненной энергии охранной башни.
        /// </summary>
        public double GuardianTowerLife { get; }

        /// <summary>
        /// Максимальное расстояние (от центра до центра), на котором охранная
        /// башня может атаковать другие объекты.
        /// </summary>
        public double GuardianTowerAttackRange { get; }

        /// <summary>
        /// Урон одной атаки охранной башни.
        /// </summary>
        public int GuardianTowerDamage { get; }

        /// <summary>
        /// Минимально возможная задержка между двумя последовательными
        /// атаками охранной башни.
        /// </summary>
        public int GuardianTowerCooldownTicks { get; }

        /// <summary>
        /// Радиус базы фракции.
        /// </summary>
        public double FactionBaseRadius { get; }

        /// <summary>
        /// Возвращает максимальное расстояние (от центра до центра), на котором база фракции
        /// обнаруживает другие объекты.
        /// </summary>
        public double FactionBaseVisionRange { get; }

        /// <summary>
        /// Начальное значение жизненной энергии базы фракции.
        /// </summary>
        public double FactionBaseLife { get; }

        /// <summary>
        /// Максимальное расстояние (от центра до центра), на котором база фракции
        /// может атаковать другие объекты.
        /// </summary>
        public double FactionBaseAttackRange { get; }

        /// <summary>
        /// Урон одной атаки базы фракции.
        /// </summary>
        public int FactionBaseDamage { get; }

        /// <summary>
        /// Минимально возможную задержку между двумя последовательными атаками базы фракции.
        /// </summary>
        public int FactionBaseCooldownTicks { get; }

        /// <summary>
        /// Длительность действия статуса BURNING.
        /// </summary>
        public int BurningDurationTicks { get; }

        /// <summary>
        /// Cуммарный урон, получаемый живым юнитом за время действия статуса BURNING.
        /// </summary>
        public int BurningSummaryDamage { get; }

        /// <summary>
        /// Длительность действия статуса EMPOWERED.
        /// </summary>
        public int EmpoweredDurationTicks { get; }

        /// <summary>
        /// Мультипликатор урона, наносимого живым юнитом под действием статуса EMPOWERED.
        /// </summary>
        /// <remarks>
        /// Мультипликатор применяется к ударам в ближнем бою, прямым попаданиям снарядов, а также
        /// взрыву «Огненного шара», но не применяется к урону, получаемому от статусов.
        /// </remarks>
        public double EmpoweredDamageFactor { get; }

        /// <summary>
        /// Длительность действия статуса FROZEN.
        /// </summary>
        public int FrozenDurationTicks { get; }

        /// <summary>
        /// Длительность действия статуса HASTENED.
        /// </summary>
        public int HastenedDurationTicks { get; }

        /// <summary>
        /// Мультилпикатор длительности действия статуса HASTENED в случае
        /// подбора бонуса.
        /// </summary>
        public double HastenedBonusDurationFactor { get; }

        /// <summary>
        /// Относительное увеличение скорости перемещения в результате дествия
        /// статуса HASTENED.
        /// </summary>
        /// <remarks>
        /// Увеличение скорости от действия статуса HASTENED и увеличение скорости в результате изучения
        /// умений, являющихся пререквизитами умения HASTE, являются аддитивными.Таким образом,
        /// максимальное значение скорости волшебника составляет 1.0 + 4.0 *
        /// movementBonusFactorPerSkillLevel + hastenedMovementBonusFactor от базовой.
        /// </remarks>
        public double HastenedMovementBonusFactor { get; }

        /// <summary>
        /// Относительное увеличение скорости поворота в результате дествия
        /// статуса HASTENED.
        /// </summary>
        public double HastenedRotationBonusFactor { get; }

        /// <summary>
        /// Длительность действия статуса SHIELDED.
        /// </summary>
        public int ShieldedDurationTicks { get; }

        /// <summary>
        /// Мультилпикатор длительности действия статуса SHIELDED в случае подбора бонуса.
        /// </summary>
        public double ShieldedBonusDurationFactor { get; }

        /// <summary>
        /// Часть урона, поглощаемую щитом.
        /// </summary>
        /// <remarks>
        /// Снижение урона применяется к ударам в ближнем бою, прямым попаданиям снарядов, а также
        /// взрыву «Огненного шара», но не применяется к урону, получаемому от статусов.
        /// </remarks>
        public double ShieldedDirectDamageAbsorptionFactor { get; }

        /// <summary>
        /// Дальность действия аур.
        /// </summary>
        public double AuraSkillRange { get; }

        /// <summary>
        /// Абсолютное увеличение дальности заклинаний волшебника за каждое
        /// последовательное изучение умения, являющегося одним из пререквизитов умения
        /// ADVANCED_MAGIC_MISSILE.
        /// </summary>
        public double RangeBonusPerSkillLevel { get; }

        /// <summary>
        /// Абсолютное увеличение урона, наносимого волшебником в результате
        /// прямых попаданий магических снарядов и взрыва «Огненного шара», за каждое
        /// последовательное изучение умения, являющегося одним из пререквизитов умения FROST_BOLT.
        /// </summary>
        public int MagicalDamageBonusPerSkillLevel { get; }

        /// <summary>
        /// Абсолютное увеличение урона, наносимого волшебником в ближнем бою,
        /// за каждое последовательное изучение умения, являющегося одним из пререквизитов умения
        /// FIREBALL.
        /// </summary>
        public int StaffDamageBonusPerSkillLevel { get; }

        /// <summary>
        /// Возвращает относительное увеличение скорости перемещения за каждое
        /// последовательное изучение умения, являющегося одним из пререквизитов умения HASTE.
        /// </summary>
        /// <remarks>
        /// Увеличение скорости от действия статуса HASTENED и увеличение скорости в результате изучения
        /// умений, являющихся пререквизитами умения HASTE, являются аддитивными.Таким образом,
        /// максимальное значение скорости волшебника составляет 
        /// 1.0 + 4.0 *  movementBonusFactorPerSkillLevel + hastenedMovementBonusFactor от базовой.
        /// </remarks>
        public double MovementBonusFactorPerSkillLevel { get; }

        /// <summary>
        /// Абсолютное уменьшение урона, получаемого волшебником в результате
        /// прямых попаданий магических снарядов, взрыва «Огненного шара» и атак строений, за каждое
        /// последовательное изучение умения, являющегося одним из пререквизитов умения SHIELD.
        /// </summary>
        public int MagicalDamageAbsorptionPerSkillLevel { get; }
    }
}