using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_BezierNode : CSerializable {
		[Serialize("pos"                    )] public Vector3 pos;
		[Serialize("tangent"                )] public Vector2 tangent;
		[Serialize("scale"                  )] public float scale;
		[Serialize("tween"                  )] public Nullable<RO2_BezierTween> tween;
		[Serialize("lumChainSpeedMultiplier")] public float lumChainSpeedMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pos));
			SerializeField(s, nameof(tangent));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(tween));
			SerializeField(s, nameof(lumChainSpeedMultiplier));
		}
	}
}

