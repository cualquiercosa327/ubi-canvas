using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTSequence_Template : BTNode_Template {
		[Serialize("nodes")] public CList<BTNodeTemplate_Ref> nodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodes));
		}
		public override uint? ClassCRC => 0xAACC4387;
	}
}

