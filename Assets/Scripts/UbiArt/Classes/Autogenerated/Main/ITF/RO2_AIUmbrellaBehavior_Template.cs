using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIUmbrellaBehavior_Template : TemplateAIBehavior {
		[Serialize("openAction"      )] public Generic<AIAction_Template> openAction;
		[Serialize("closedAction"    )] public Generic<AIAction_Template> closedAction;
		[Serialize("openingAction"   )] public Generic<AIAction_Template> openingAction;
		[Serialize("closingAction"   )] public Generic<AIAction_Template> closingAction;
		[Serialize("warningAction"   )] public Generic<AIAction_Template> warningAction;
		[Serialize("closedStateTime" )] public float closedStateTime;
		[Serialize("warningStateTime")] public float warningStateTime;
		[Serialize("weightThreshold" )] public float weightThreshold;
		[Serialize("closeWithWeight" )] public bool closeWithWeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(openAction));
			SerializeField(s, nameof(closedAction));
			SerializeField(s, nameof(openingAction));
			SerializeField(s, nameof(closingAction));
			SerializeField(s, nameof(warningAction));
			SerializeField(s, nameof(closedStateTime));
			SerializeField(s, nameof(warningStateTime));
			SerializeField(s, nameof(weightThreshold));
			SerializeField(s, nameof(closeWithWeight));
		}
		public override uint? ClassCRC => 0x5D3B7B7D;
	}
}

