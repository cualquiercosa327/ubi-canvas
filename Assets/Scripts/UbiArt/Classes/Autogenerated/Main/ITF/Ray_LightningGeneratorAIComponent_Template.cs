using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LightningGeneratorAIComponent_Template : TimedSpawnerAIComponent_Template {
		[Serialize("pivotBoneName"      )] public StringID pivotBoneName;
		[Serialize("minAngle"           )] public Angle minAngle;
		[Serialize("maxAngle"           )] public Angle maxAngle;
		[Serialize("addOrientationInput")] public StringID addOrientationInput;
		[Serialize("dynamicOrientation" )] public int dynamicOrientation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pivotBoneName));
			SerializeField(s, nameof(minAngle));
			SerializeField(s, nameof(maxAngle));
			SerializeField(s, nameof(addOrientationInput));
			SerializeField(s, nameof(dynamicOrientation));
		}
		public override uint? ClassCRC => 0x7563A31A;
	}
}

