﻿namespace GlobalLib.Support.Underground2.Class
{
    public partial class CarTypeInfo
    {
        /// <summary>
        /// Game index to which the class belongs to.
        /// </summary>
        public int GameINT { get => (int)Core.GameINT.Underground2; }

        /// <summary>
        /// Game string to which the class belongs to.
        /// </summary>
        public string GameSTR { get => Core.GameSTR.Underground2; }

        /// <summary>
        /// Database to which the class belongs to.
        /// </summary>
        public Database.Underground2 Database { get; set; }

        public const int MaxCNameLength = 0xD;
        public const int CNameOffsetAt = 0;
        public const int BaseClassSize = 0x890;
    }
}