using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_404_sub_B54560 : CSerializable {
		[Serialize("EnemyPath")] public Path EnemyPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(EnemyPath));
		}
		public override uint? ClassCRC => 0x1D9217DE;
	}
}

