﻿using System;
using Polkadot.BinarySerializer;
using Polkadot.DataStructs;
using Polkadot.Utils;

namespace NftUnity.Models.Calls.Item
{
    public class ItemKey
    {
        [Serialize(0)]
        public ulong CollectionId;

        [Serialize(1)]
        public ulong ItemId;

        public ItemKey()
        {
        }

        public ItemKey(ulong collectionId, ulong itemId)
        {
            CollectionId = collectionId;
            ItemId = itemId;
        }
    }
}