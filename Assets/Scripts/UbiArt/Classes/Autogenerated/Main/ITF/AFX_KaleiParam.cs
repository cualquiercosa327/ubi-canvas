using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class AFX_KaleiParam : CSerializable {
		[Serialize("use"      )] public bool use;
		[Serialize("pixelSize")] public float pixelSize;
		[Serialize("UV1"      )] public Vector2 UV1;
		[Serialize("UV2"      )] public Vector2 UV2;
		[Serialize("UV3"      )] public Vector2 UV3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(use), boolAsByte: true);
			} else {
				SerializeField(s, nameof(use));
			}
			SerializeField(s, nameof(pixelSize));
			SerializeField(s, nameof(UV1));
			SerializeField(s, nameof(UV2));
			SerializeField(s, nameof(UV3));
		}
	}
}

