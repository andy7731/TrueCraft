﻿using System;

namespace TrueCraft.API.Logic
{
    public struct BlockDescriptor
    {
        public byte ID;
        public byte Metadata;
        public byte BlockLight;
        public byte SkyLight;
        public Coordinates3D Coordinates;
    }
}