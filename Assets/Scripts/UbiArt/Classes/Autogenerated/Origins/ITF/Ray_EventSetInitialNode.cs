using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventSetInitialNode : Event {
		[Serialize("getNodeFromSender"   )] public bool getNodeFromSender;
		[Serialize("interruptCurrentNode")] public bool interruptCurrentNode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(getNodeFromSender));
			SerializeField(s, nameof(interruptCurrentNode));
		}
		public override uint? ClassCRC => 0xCEA19929;
	}
}

