using UnityEngine;

namespace UbiArt.ITF {
	public partial class TrajectorySpawnerComponent : CSerializable {
		[Serialize("spawneePaths")] public Placeholder spawneePaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(spawneePaths));
			}
		}
		public override uint? ClassCRC => 0x629061C6;
	}
}

