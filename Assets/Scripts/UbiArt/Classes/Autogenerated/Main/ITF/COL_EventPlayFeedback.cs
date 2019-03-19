using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventPlayFeedback : CSerializable {
		[Serialize("sender"    )] public uint sender;
		[Serialize("feedbackID")] public StringID feedbackID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(feedbackID));
		}
		public override uint? ClassCRC => 0x51CF85E8;
	}
}

