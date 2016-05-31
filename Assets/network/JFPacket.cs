﻿using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class JFPackage
{
    //结构体序列化
    [System.Serializable]
    //4字节对齐 iphone 和 android上可以1字节对齐
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct WorldPackage
    {

        public short header;
        public short total;
        public uint no;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] content;

        public WorldPackage(short _h, short _t, uint _n, byte[] _c)
        {
            header = _h;
            total = _t;
            no = _n;
            content = _c;
        }


    };

}