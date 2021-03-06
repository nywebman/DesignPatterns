﻿namespace DesignPatterns.Repository
{
    public class City : IEntity
    {
        public string Name { get; set; }
        public virtual City MyCity { get; set; }

        #region IEntity Members

        public int Id { get; set; }

        #endregion
    }
}
