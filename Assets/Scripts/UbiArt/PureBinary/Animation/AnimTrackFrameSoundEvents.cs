﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackFrameSoundEvents::serialize
	public class AnimTrackFrameSoundEvents : ICSerializable {
		public StringID sid;
		public float unk0;
		public uint unk1;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref sid);
			s.Serialize(ref unk0);
			s.Serialize(ref unk1);
		}
	}
}
