using System;

namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    public sealed class PlayerContext
    {
        private readonly Wizard[] _wizards;

        public PlayerContext(Wizard[] wizards, World world)
        {
            _wizards = new Wizard[wizards.Length];
            Array.Copy(wizards, _wizards, wizards.Length);

            World = world;
        }

        public Wizard[] Wizards
        {
            get
            {
                if (_wizards == null)
                {
                    return null;
                }

                var wizards = new Wizard[_wizards.Length];
                Array.Copy(_wizards, wizards, _wizards.Length);
                return wizards;
            }
        }

        public World World { get; }
    }
}