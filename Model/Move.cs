﻿using System;

namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Стратегия игрока может управлять волшебником посредством установки свойств объекта данного класса.
    /// </summary>
    public class Move
    {
        private Message[] _messages;

        /// <summary>
        /// Текущая установка скорости перемещения.
        /// </summary>
        /// <remarks>
        /// Установка скорости перемещения по умолчанию лежит в интервале от
        /// -game.wizardBackwardSpeed до game.wizardForwardSpeed, однако границы интервала
        /// могут быть расширены в зависимости от изученных волшебником умений, от действия
        /// некоторых аур, а также в случае действия статуса HASTENED.
        /// Значения, выходящие за интервал, будут приведены к ближайшей его границе.
        /// Положительные значения соответствуют движению вперёд.
        /// Если hypot(speed / maxSpeed, strafeSpeed / maxStrafeSpeed) больше 1.0, то обе
        /// установки скорости перемещения(speed и strafeSpeed) будут поделены игровым
        /// симулятором на это значение.
        /// </remarks>
        public double Speed { get; set; }

        /// <summary>
        /// Текущая установка скорости перемещения боком.
        /// </summary>
        /// <remarks>
        /// Установка скорости перемещения по умолчанию лежит в интервале от
        /// -game.wizardStrafeSpeed до game.wizardStrafeSpeed, однако границы интервала могут
        /// быть расширены в зависимости от изученных волшебником умений, от действия некоторых
        /// аур, а также в случае действия статуса HASTENED.
        /// Значения, выходящие за интервал, будут приведены к ближайшей его границе.
        /// Положительные значения соответствуют движению направо.
        /// Если hypot(speed / maxSpeed, strafeSpeed / maxStrafeSpeed) больше 1.0, то обе
        /// установки скорости перемещения(speed и strafeSpeed) будут поделены игровым
        /// симулятором на это значение.
        /// </remarks>
        public double StrafeSpeed { get; set; }

        /// <summary>
        /// Текущий угол поворота волшебника.
        /// </summary>
        /// <remarks>
        /// Угол поворота задаётся в радианах относительно текущего направления волшебника и
        /// обычно ограничен интервалом от -game.wizardMaxTurnAngle до
        /// game.wizardMaxTurnAngle.Если на волшебника действует магический статус HASTENED, то
        /// нижнюю и правую границу интервала необходимо умножить на 1.0 +
        /// game.hastenedRotationBonusFactor.
        /// Значения, выходящие за интервал, будут приведены к ближайшей его границе.
        /// Положительные значения соответствуют повороту по часовой стрелке.
        /// </remarks>
        public double Turn { get; set; }

        /// <summary>
        /// Текущее действие волшебника.
        /// </summary>
        /// <remarks>
        /// Действие может быть проигнорировано игровым симулятором, если у волшебника
        /// недостаточно магической энергии для его совершения и/или волшебник ещё не успел
        /// восстановиться после предыдущего действия.
        /// </remarks>
        public ActionType? Action { get; set; }

        /// <summary>
        /// Текущий угол полёта магического снаряда.
        /// </summary>
        /// <remarks>
        /// Угол полёта задаётся в радианах относительно текущего направления волшебника и
        /// ограничен интервалом от -game.staffSector / 2.0 до game.staffSector / 2.0.
        /// Значения, выходящие за интервал, будут приведены к ближайшей его границе.
        /// Положительные значения соответствуют повороту по часовой стрелке.
        /// Параметр будет проигнорирован игровым симулятором, если действие волшебника не
        /// связано с созданием магического снаряда.
        /// </remarks>
        public double CastAngle { get; set; }

        /// <summary>
        /// Текущая установка для ближней границы боевого применения
        /// магического снаряда.
        /// </summary>
        /// <remarks>
        /// Если расстояние от центра снаряда до точки его появления меньше, чем значение данного
        /// параметра, то боевые свойства снаряда игнорируются.Снаряд беспрепятственно проходит
        /// сквозь все другие игровые объекты, за исключением деревьев.
        /// Значение параметра по умолчанию равно 0.0. Столкновения снаряда и юнита, который его
        /// создал, игнорируются.
        /// Параметр будет проигнорирован игровым симулятором, если действие волшебника не
        /// связано с созданием магического снаряда.
        /// </remarks>
        public double MinCastDistance { get; set; }

        /// <summary>
        /// Текущая установка для дальней границы боевого применения магического
        /// снаряда.
        /// </summary>
        /// <remarks>
        /// Если расстояние от центра снаряда до точки его появления больше, чем значение данного
        /// параметра, то снаряд убирается из игрового мира.При этом, снаряд типа FIREBALL
        /// детонирует.
        /// Значение параметра по умолчанию заведомо выше максимальной дальности полёта любого
        /// типа снарядов в игре.
        /// Параметр будет проигнорирован игровым симулятором, если действие волшебника не
        /// связано с созданием магического снаряда.
        /// </remarks>
        public double MaxCastDistance { get; set; } = 10000.0D;

        /// <summary>
        /// Идентификатор текущей цели для применения магического статуса.
        /// </summary>
        /// <remarks>
        /// Допустимыми целями являются только волшебники дружественной фракции. Если
        /// волшебник с указанным идентификатором не найден, то статус применяется непосредственно
        /// к волшебнику, совершающему действие.Относительный угол до цели должен лежать в
        /// интервале от -game.staffSector / 2.0 до game.staffSector / 2.0, а максимальная
        /// дистанция ограничена дальностью полёта магического снаряда этого волшебника. Её
        /// базовое значение равно game.wizardCastRange, однако оно может быть увеличено после
        /// изучения некоторых умений.
        ///
        /// Значение параметра по умолчанию равно -1.
        ///
        /// Параметр будет проигнорирован игровым симулятором, если действие волшебника не
        /// связано с применением магического статуса.
        /// </remarks>
        public long StatusTargetId { get; set; } = -1L;

        /// <summary>
        /// Выбранное для изучения умение.
        /// </summary>
        /// <remarks>
        /// Установка будет проигнорирована игровым симулятором, если текущий уровень волшебника
        /// меньше либо равен количеству уже изученных умений.Некоторые умения также могут
        /// требовать предварительного изучения других умений.
        /// Изучение умений доступно не во всех режимах игры.
        /// </remarks>
        public SkillType? SkillToLearn { get; set; }

        /// <summary>
        /// Текущие сообщения для волшебников дружественной фракции.
        /// </summary>
        /// <remarks>
        /// Доступно для использования только верховному волшебнику (wizard.master). Если
        /// используется, количество сообщений должно быть строго равно количеству волшебников
        /// дружественной фракции(живых или ожидающих возрождения) за исключением самого
        /// верховного волшебника.Нарушение данных условий может привести к игнорированию
        /// параметра игровым симулятором или даже к обрыву соединения со стратегией участника.
        /// Сообщения адресуются в порядке возрастания идентификаторов волшебников. Отдельные
        /// сообщения могут быть пустыми (равны null), если это поддерживается языком
        /// программирования, который использует стратегия.В противном случае все элементы
        /// должны быть корректными сообщениями.
        /// Игровой симулятор вправе проигнорировать сообщение конкретному волшебнику, если для
        /// него в системе уже зарегистрировано и ещё им не получено другое сообщение.Если в тик
        /// получения сообщения волшебник мёртв, то данное сообщение будет удалено из игрового
        /// мира и волшебник никогда его не получит.
        /// Отправка сообщений доступна не во всех режимах игры.
        /// </remarks>
        public Message[] Messages
        {
            get
            {
                if (_messages == null)
                {
                    return null;
                }

                var messages = new Message[_messages.Length];
                Array.Copy(_messages, messages, _messages.Length);
                return messages;
            }
            set
            {
                if (value == null)
                {
                    _messages = null;
                    return;
                }

                _messages = new Message[value.Length];
                Array.Copy(value, _messages, value.Length);
            }
        }
    }
}