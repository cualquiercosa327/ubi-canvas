using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AdditionalBehaviorsComponent_Template : ActorComponent_Template {
		[Serialize("externBehaviorDataList"     )] public CList<ExternBehaviorData_Template> externBehaviorDataList;
		[Serialize("startBhv"                   )] public StringID startBhv;
		[Serialize("onTriggerActiveBhv"         )] public StringID onTriggerActiveBhv;
		[Serialize("onTriggerDesactivateBhv"    )] public StringID onTriggerDesactivateBhv;
		[Serialize("disablePhys"                )] public bool disablePhys;
		[Serialize("onTriggerActiveCheckNextBhv")] public bool onTriggerActiveCheckNextBhv;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(startBhv));
				SerializeField(s, nameof(onTriggerActiveBhv));
				SerializeField(s, nameof(onTriggerDesactivateBhv));
				SerializeField(s, nameof(disablePhys));
				SerializeField(s, nameof(onTriggerActiveCheckNextBhv));
			} else {
				SerializeField(s, nameof(externBehaviorDataList));
				SerializeField(s, nameof(startBhv));
				SerializeField(s, nameof(onTriggerActiveBhv));
				SerializeField(s, nameof(onTriggerDesactivateBhv));
				SerializeField(s, nameof(disablePhys));
				SerializeField(s, nameof(onTriggerActiveCheckNextBhv));
			}
		}
		public override uint? ClassCRC => 0x56987861;
	}
}

