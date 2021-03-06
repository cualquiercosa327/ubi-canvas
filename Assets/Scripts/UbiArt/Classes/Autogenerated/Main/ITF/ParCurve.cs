using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ParCurve : CSerializable {
		[Serialize("baseTime" )] public float baseTime;
		[Serialize("outputMin")] public Vector3 outputMin;
		[Serialize("outputMax")] public Vector3 outputMax;
		[Serialize("curve"    )] public Spline curve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(baseTime));
			SerializeField(s, nameof(outputMin));
			SerializeField(s, nameof(outputMax));
			SerializeField(s, nameof(curve));
		}
		public override uint? ClassCRC => 0xF241D702;
	}
}

