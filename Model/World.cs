using System;

namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Этот класс описывает игровой мир. Содержит также описания всех игроков и игровых объектов («юнитов»).
    /// </summary>
    public class World
    {
        private readonly Player[] _players;
        private readonly Wizard[] _wizards;
        private readonly Minion[] _minions;
        private readonly Projectile[] _projectiles;
        private readonly Bonus[] _bonuses;
        private readonly Building[] _buildings;
        private readonly Tree[] _trees;

        public World(int tickIndex, int tickCount, double width, double height, Player[] players, Wizard[] wizards,
                Minion[] minions, Projectile[] projectiles, Bonus[] bonuses, Building[] buildings, Tree[] trees)
        {
            TickIndex = tickIndex;
            TickCount = tickCount;
            Width = width;
            Height = height;

            _players = new Player[players.Length];
            Array.Copy(players, _players, players.Length);

            _wizards = new Wizard[wizards.Length];
            Array.Copy(wizards, _wizards, wizards.Length);

            _minions = new Minion[minions.Length];
            Array.Copy(minions, _minions, minions.Length);

            _projectiles = new Projectile[projectiles.Length];
            Array.Copy(projectiles, _projectiles, projectiles.Length);

            _bonuses = new Bonus[bonuses.Length];
            Array.Copy(bonuses, _bonuses, bonuses.Length);

            _buildings = new Building[buildings.Length];
            Array.Copy(buildings, _buildings, buildings.Length);

            _trees = new Tree[trees.Length];
            Array.Copy(trees, _trees, trees.Length);
        }

        /// <summary>
        /// Номер текущего тика.
        /// </summary>
        public int TickIndex { get; }

        /// <summary>
        /// Базовая длительность игры в тиках. Реальная длительность может
        /// отличаться от этого значения в меньшую сторону.Эквивалентно game.tickCount.
        /// </summary>
        public int TickCount { get; }

        /// <summary>
        /// Ширина мира.
        /// </summary>
        public double Width { get; }

        /// <summary>
        /// Высота мира.
        /// </summary>
        public double Height { get; }

        /// <summary>
        /// Список игроков (в случайном порядке). После каждого тика объекты,
        /// задающие игроков, пересоздаются.
        /// </summary>
        public Player[] Players
        {
            get
            {
                if (_players == null)
                {
                    return null;
                }

                Player[] players = new Player[_players.Length];
                Array.Copy(_players, players, _players.Length);
                return players;
            }
        }

        /// <summary>
        /// Список видимых волшебников (в случайном порядке). После каждого тика
        /// объекты, задающие волшебников, пересоздаются.
        /// </summary>
        public Wizard[] Wizards
        {
            get
            {
                if (_wizards == null)
                {
                    return null;
                }

                Wizard[] wizards = new Wizard[_wizards.Length];
                Array.Copy(_wizards, wizards, _wizards.Length);
                return wizards;
            }
        }

        /// <summary>
        /// Список видимых последователей (в случайном порядке). После каждого
        /// тика объекты, задающие последователей, пересоздаются.
        /// </summary>
        public Minion[] Minions
        {
            get
            {
                if (_minions == null)
                {
                    return null;
                }

                Minion[] minions = new Minion[_minions.Length];
                Array.Copy(_minions, minions, _minions.Length);
                return minions;
            }
        }

        /// <summary>
        /// Список видимых магических снарядов (в случайном порядке). После
        /// каждого тика объекты, задающие снаряды, пересоздаются.
        /// </summary>
        public Projectile[] Projectiles
        {
            get
            {
                if (_projectiles == null)
                {
                    return null;
                }

                Projectile[] projectiles = new Projectile[_projectiles.Length];
                Array.Copy(_projectiles, projectiles, _projectiles.Length);
                return projectiles;
            }
        }

        /// <summary>
        /// Список видимых бонусов (в случайном порядке). После каждого тика
        /// объекты, задающие бонусы, пересоздаются.
        /// </summary>
        public Bonus[] Bonuses
        {
            get
            {
                if (_bonuses == null)
                {
                    return null;
                }

                Bonus[] bonuses = new Bonus[_bonuses.Length];
                Array.Copy(_bonuses, bonuses, _bonuses.Length);
                return bonuses;
            }
        }

        /// <summary>
        /// Список видимых строений (в случайном порядке). После каждого тика
        /// объекты, задающие строения, пересоздаются.
        /// </summary>
        public Building[] Buildings
        {
            get
            {
                if (_buildings == null)
                {
                    return null;
                }

                Building[] buildings = new Building[_buildings.Length];
                Array.Copy(_buildings, buildings, _buildings.Length);
                return buildings;
            }
        }

        /// <summary>
        /// Список видимых деревьев (в случайном порядке). После каждого тика
        /// объекты, задающие деревья, пересоздаются.
        /// </summary>
        public Tree[] Trees
        {
            get
            {
                if (_trees == null)
                {
                    return null;
                }

                Tree[] trees = new Tree[_trees.Length];
                Array.Copy(_trees, trees, _trees.Length);
                return trees;
            }
        }

        /// <summary>
        /// Получает вашего игрока.
        /// </summary>
        /// <returns>
        /// Возвращает инициализированный экземпляр класса <seealso cref="Player"/>.
        /// </returns>
        public Player GetMyPlayer()
        {
            for (int playerIndex = _players.Length - 1; playerIndex >= 0; --playerIndex)
            {
                Player player = _players[playerIndex];
                if (player.IsMe)
                {
                    return player;
                }
            }

            return null;
        }
    }
}