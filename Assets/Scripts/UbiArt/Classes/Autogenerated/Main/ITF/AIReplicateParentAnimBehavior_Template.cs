using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AIReplicateParentAnimBehavior_Template : TemplateAIBehavior {
		[Serialize("useParentBind")] public bool useParentBind;
		[Serialize("defaultAnim"  )] public StringID defaultAnim;
		[Serialize("animsToAvoid" )] public CList<StringID> animsToAvoid;
		[Serialize("name"         )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(useParentBind));
				SerializeField(s, nameof(defaultAnim));
				SerializeField(s, nameof(animsToAvoid));
			} else {
				SerializeField(s, nameof(useParentBind));
				SerializeField(s, nameof(defaultAnim));
				SerializeField(s, nameof(animsToAvoid));
			}
		}
		public override uint? ClassCRC => 0x445E5733;
	}
}

