﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimBoneDyn::serialize
	public class AnimBoneDyn : CSerializable {
		[Serialize("vec0"    )] public Vector2 vec0;
		[Serialize("flt1"    )] public float float1;
		[Serialize("xOffset" )] public float xOffset;
		[Serialize("position")] public Vector2 position;
		[Serialize("angle"   )] public Angle angle;
		[Serialize("flt4"    )] public float z;
		[Serialize("scale"   )] public Vector2 scale;
		[Serialize("flt6"    )] public float float6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(vec0));
			SerializeField(s, nameof(float1));
			if (Settings.s.engineVersion <= Settings.EngineVersion.RO) {
				SerializeField(s, nameof(xOffset));
			}
			SerializeField(s, nameof(position));
			SerializeField(s, nameof(angle));
			SerializeField(s, nameof(z));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(float6));
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

		00000000 00000000 00000000 00000000 3F800000 00000000 00000000 3F800000 3F800000 3F800000
		00000000 00000000 00000000 3F4D0DA0 3B4360CC 3C1167BB 40A00000 3EEEA931 3F800000 3F800000

		Adv:
		00000000 00000000 00000000 3F014035 3EFD7F95 BBF572F1 00000000 3EDEA6B5 3F800000 3F800000
		
		Reordered:
		00000000 00000000 00000000 3F800000 3F800000 3F800000 00000000 00000000 3F800000 00000000
		00000000 00000000 3E45FB5D BDC4D114 3F826F70 3F800000 00000000 3FC90FDB 3F800000 00000000
		00000000 00000000 3C51CAC0 BC89DB40 3F851096 3F800000 00000000 3FC90FDB 3F800000 C0800000
		00000000 00000000 3F05EE23 3F34D4EB 3F813C5B 3F800000 00000000 400E27DA 3F800000 C0000000
		00000000 00000000 BBF7AA6B 3F9218C6 3FC8CB01 3F800000 00000000 3FC713DD 3F800000 C0400000
		00000000 00000000 BF3D2DDE BEA5EA2E 3F0F24C5 3F800000 00000000 3FC46C36 3F800000 00000000
		vec2d             vec2d             vec2d             x        x        x        x 
		*/
	}
}
