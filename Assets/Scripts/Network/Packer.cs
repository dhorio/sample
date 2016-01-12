using UnityEngine;
using System.Collections;

namespace Network
{
    public static class Packer
    {
        // シリアライズ
        static MsgPack.ObjectPacker packer = new MsgPack.ObjectPacker();

        public static byte[] Pack<Type>(Type data)
        {
            return packer.Pack(data);
        }

        public static Type UnPack<Type>(byte[] data)
        {
            return packer.Unpack<Type>(data);
        }
    }
}