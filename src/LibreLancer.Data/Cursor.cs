﻿// MIT License - Copyright (c) Malte Rupprecht
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Numerics;
using LibreLancer.Ini;
namespace LibreLancer.Data
{
	public class Cursor
	{
        [Entry("nickname")]
		public string Nickname;
        [Entry("blend")]
		public float Blend; //TODO: What is this?
        [Entry("spin")]
		public float Spin = 0;
        [Entry("scale")]
		public float Scale = 1;
        [Entry("hotspot")]
		public Vector2 Hotspot = Vector2.Zero;
        [Entry("color")]
		public Color4 Color = Color4.White;
		
        public string Shape;
        bool HandleEntry(Entry e)
        {
            if(e.Name.Equals("anim", StringComparison.OrdinalIgnoreCase))
            {
                Shape = e[0].ToString();
                //figure out following 2 int components
                return true;
            }
            return false;
        }
    }
}
