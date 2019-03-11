using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_MultiPiecesActorAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("piecesDataList")] public Placeholder piecesDataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(piecesDataList));
		}
		public override uint? ClassCRC => 0xD2404FEB;
	}
}

