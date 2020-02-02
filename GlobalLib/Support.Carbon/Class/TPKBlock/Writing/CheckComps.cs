﻿namespace GlobalLib.Support.Carbon.Class
{
    public partial class TPKBlock : Shared.Class.TPKBlock
    {
        /// <summary>
        /// Checks texture compressions and tpk compressions for matching.
        /// </summary>
        protected override void CheckComps()
        {
            this.compressions.Clear();
            for (int a1 = 0; a1 < this.Textures.Count; ++a1)
                this.compressions.Add(Utils.EA.Comp.GetInt(this.Textures[a1].Compression));
        }
    }
}