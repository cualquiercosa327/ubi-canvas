﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	public class Angle : ICSerializable {
		public float angle;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize<float>(ref angle);
		}
		
		// Casts
		public static implicit operator float(Angle a) {
			return a.angle;
		}
		public static implicit operator Angle(float a) {
			return new Angle { angle = a };
		}
		public static implicit operator Angle(AngleAmount a) {
			return new Angle { angle = a.angle };
		}
	}
}