using System;
namespace Domain
{
    public class Dice
    {
        #region Fields
        private readonly Random _randomizer = new();
        #endregion

        #region Properties
        public int Dots { get; private set; }
        #endregion

        #region Methods
        public Dice()
        {
            Dots = 6;
        }
        public void Roll()
        {
            Dots = _randomizer.Next(1, 7);
        }
        #endregion
    }
}
