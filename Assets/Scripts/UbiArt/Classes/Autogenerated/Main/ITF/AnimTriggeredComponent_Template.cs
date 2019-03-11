using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTriggeredComponent_Template : ActorComponent_Template {
		[Serialize("TriggeredAction"  )] public StringID TriggeredAction;
		[Serialize("UntriggeredAction")] public StringID UntriggeredAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TriggeredAction));
			SerializeField(s, nameof(UntriggeredAction));
		}
		public override uint? ClassCRC => 0x542821A5;
	}
}

