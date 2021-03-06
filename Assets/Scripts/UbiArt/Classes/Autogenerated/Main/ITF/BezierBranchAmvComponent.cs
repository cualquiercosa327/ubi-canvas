using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class BezierBranchAmvComponent : BezierBranchComponent {
		[Serialize("flipTexture")] public bool flipTexture;
		[Serialize("zones"      )] public CList<BezierBranchAmvComponent.Zone> zones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(flipTexture), boolAsByte: true);
			} else {
				SerializeField(s, nameof(flipTexture));
				SerializeField(s, nameof(zones));
			}
		}
		[Games(GameFlags.RA)]
		public partial class Zone : CSerializable {
			[Serialize("startDist")] public float startDist;
			[Serialize("endDist"  )] public float endDist;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(startDist));
				SerializeField(s, nameof(endDist));
			}
		}
		public override uint? ClassCRC => 0xA3BCCC12;
	}
}

