using System;

namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Класс определяет сообщение, которое верховный волшебник (wizard.master) может отправлять другим членам
    /// фракции, используя телепатическую связь.
    /// </summary>
    /// <remarks>
    /// Сообщение отправляется персонально каждому волшебнику.Другие волшебники не могут его перехватить.
    /// Адресат получает сообщение в следующий игровой тик или позднее, в зависимости от размера сообщения.
    /// Волшебник волен проигнорировать как любую отдельную часть сообщения, так и всё сообщение целиком, однако это
    /// может привести к поражению дружественной фракции.
    /// </remarks>
    public class Message
    {
        private readonly byte[] _rawMessage;

        public Message(LaneType lane, SkillType? skillToLearn, byte[] rawMessage)
        {
            Lane = lane;
            SkillToLearn = skillToLearn;

            _rawMessage = new byte[rawMessage.Length];
            Array.Copy(rawMessage, _rawMessage, rawMessage.Length);
        }

        /// <summary>
        /// Указание контролировать определённую дорожку.
        /// </summary>
        public LaneType Lane { get; }

        /// <summary>
        /// Указание изучить какое-либо умение.
        /// </summary>
        /// <remarks>
        /// Умение может требовать предварительного изучения других умений или быть недоступно для
        /// изучения в данный момент в связи с низким уровнем волшебника.Волшебнику рекомендуется
        /// запомнить указание и двигаться в направлении его реализации.При этом, более позднее указание
        /// должно считаться более приоритетным.
        /// Значение поля может быть доступно не во всех режимах игры.
        /// </remarks>
        public SkillType? SkillToLearn { get; }

        /// <summary>
        /// Текстовое сообщение на забытом древнем языке.
        /// </summary>
        /// <remarks>
        /// Максимальная длина сообщения составляет game.rawMessageMaxLength. При этом, скорость
        /// отправки сообщения зависит от его длины.Если текстовая часть сообщения пуста, то адресат
        /// получит его уже в следующий игровой тик.В противном случае, момент получения сообщения
        /// будет отложен на ceil(rawMessage.length / game.rawMessageTransmissionSpeed) игровых
        /// тиков.
        /// Значение поля может быть доступно не во всех режимах игры.
        /// </remarks>
        public byte[] RawMessage
        {
            get
            {
                if (_rawMessage == null)
                {
                    return null;
                }

                var rawMessage = new byte[_rawMessage.Length];
                Array.Copy(_rawMessage, rawMessage, _rawMessage.Length);
                return rawMessage;
            }
        }
    }
}