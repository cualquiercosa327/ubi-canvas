﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.FriseOrigins {
	// See: ITF::FluidFriseLayer::serialize
	public class FluidFriseLayer : CSerializable {
		[Serialize("erosion"                      )] public uint erosion;
		[Serialize("color"                        )] public Color color;
		[Serialize("threshold"                    )] public float threshold;
		[Serialize("gameMaterial"                 )] public Path gameMaterial;
		[Serialize("backsideGameMaterial"         )] public Path backsideGameMaterial;
		[Serialize("collisionHeight"              )] public float collisionHeight;
		[Serialize("hasBacksideInversion"         )] public bool hasBacksideInversion;
		[Serialize("forcedHeightWhenNotColored"   )] public float forcedHeightWhenNotColored;
		[Serialize("hasForcedHeightWhenNotColored")] public bool hasForcedHeightWhenNotColored;


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(threshold));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(gameMaterial));
			SerializeField(s, nameof(backsideGameMaterial));
			SerializeField(s, nameof(collisionHeight));
			SerializeField(s, nameof(erosion));
			SerializeField(s, nameof(hasBacksideInversion));
			SerializeField(s, nameof(forcedHeightWhenNotColored));
			SerializeField(s, nameof(hasForcedHeightWhenNotColored));
		}
	}
}
