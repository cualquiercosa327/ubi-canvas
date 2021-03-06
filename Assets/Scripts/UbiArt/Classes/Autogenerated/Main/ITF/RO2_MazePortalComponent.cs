using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MazePortalComponent : ActorComponent {
		[Serialize("wallPos"   )] public Vector2 wallPos;
		[Serialize("wallExtent")] public Vector2 wallExtent;
		[Serialize("debug"     )] public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(wallPos));
				SerializeField(s, nameof(wallExtent));
				SerializeField(s, nameof(debug));
			}
		}
		public override uint? ClassCRC => 0xE0B41115;
	}
}

