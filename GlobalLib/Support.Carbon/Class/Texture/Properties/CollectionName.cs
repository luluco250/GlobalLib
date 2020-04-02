﻿namespace GlobalLib.Support.Carbon.Class
{
    public partial class Texture
    {
        private string _collection_name;

        /// <summary>
        /// Collection name of the variable.
        /// </summary>
        [Reflection.Attributes.AccessModifiable()]
        public override string CollectionName
        {
            get => this._collection_name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new System.ArgumentNullException("This value cannot be left empty.");
                if (value.Contains(" "))
                    throw new System.Exception("CollectionName cannot contain whitespace.");
                int index = this.Database.GetClassIndex(this._parent_TPK, GlobalLib.Database.eClassType.TPKBlock);
                var key = Utils.Bin.Hash(value);
                var type = Reflection.Enum.eKeyType.BINKEY;
                if (this.Database.TPKBlocks[index].GetTextureIndex(key, type) != -1)
                    throw new Reflection.Exception.CollectionExistenceException();
                this._collection_name = value;
                this.BinKey = Utils.Bin.Hash(value);
            }
        }
    }
}