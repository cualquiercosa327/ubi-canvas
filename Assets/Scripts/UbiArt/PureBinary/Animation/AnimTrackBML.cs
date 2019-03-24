﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.Animation {
	// See: ITF::AnimTrackBML::serialize
	public class AnimTrackBML : ICSerializable {
		public float unk;
		public CList<Entry> entries;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref unk);
			s.Serialize(ref entries);
		}

		public class Entry : ICSerializable {
			public StringID sid0;
			public StringID sid1;

			public void Serialize(CSerializerObject s, string name) {
				s.Serialize(ref sid0);
				s.Serialize(ref sid1);
			}
		}
		/*
		Example (from yellow_afraid_to_red_afraid.anm.ckd):
		00000000 00000004 93267C52 40B0FAC4 93267C52 4000C95C 93267C52 F6DD2736 93267C52 07A08511
		40000000 00000004 93267C52 40B0FAC4 93267C52 4000C95C 93267C52 F6DD2736 93267C52 7D85DF00
		40A00000 00000004 93267C52 40B0FAC4 93267C52 4000C95C 93267C52 F6DD2736 93267C52 07A08511
		41000000 00000004 93267C52 40B0FAC4 93267C52 4000C95C 93267C52 F6DD2736 93267C52 7D85DF00
		41100000 00000004 93267C52 7C215FF2 93267C52 546CB87B 93267C52 CA574892 93267C52 7C1129DA
		41300000 00000004 93267C52 7C215FF2 93267C52 546CB87B 93267C52 CA574892 93267C52 99CB2DF4
		41600000 00000004 93267C52 7C215FF2 93267C52 546CB87B 93267C52 CA574892 93267C52 7C1129DA
		41880000 00000004 93267C52 7C215FF2 93267C52 546CB87B 93267C52 CA574892 93267C52 99CB2DF4
		*/
	}
}
