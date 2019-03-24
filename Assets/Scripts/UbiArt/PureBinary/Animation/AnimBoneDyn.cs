﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimBoneDyn::serialize
	public class AnimBoneDyn : ICSerializable {
		public Vector2 vec0;
		public float float1;
		public Vector2 vec2;
		public float float3;
		public float float4;
		public Vector2 vec5;
		public float float6;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref vec0);
			s.Serialize(ref float1);
			s.Serialize(ref vec2);
			s.Serialize(ref float3);
			s.Serialize(ref float4);
			s.Serialize(ref vec5);
			s.Serialize(ref float6);
		}
		/*
		Example:
		00000000 00000000 00000000 00000000 3F800000 00000000 00000000 3F800000 3F800000 3F800000
		00000000 00000000 00000000 3E45FB5D BDC4D114 3FC90FDB 00000000 3F826F70 3F800000 3F800000
		00000000 00000000 00000000 3C51CAC0 BC89DB40 3FC90FDB C0800000 3F851096 3F800000 3F800000
		00000000 00000000 00000000 3F05EE23 3F34D4EB 400E27DA C0000000 3F813C5B 3F800000 3F800000
		00000000 00000000 00000000 BBF7AA6B 3F9218C6 3FC713DD C0400000 3FC8CB01 3F800000 3F800000
		00000000 00000000 00000000 BF3D2DDE BEA5EA2E 3FC46C36 00000000 3F0F24C5 3F800000 3F800000
		vec2d             x        vec2d             x        x        vec2d             x
		*/
	}
}
