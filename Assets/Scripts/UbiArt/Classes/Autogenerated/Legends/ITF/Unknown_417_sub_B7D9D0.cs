using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_417_sub_B7D9D0 : CSerializable {
		[Serialize("SpawnPos")] public Placeholder SpawnPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(SpawnPos));
			}
		}
		public override uint? ClassCRC => 0x45E5F4C0;
	}
}

