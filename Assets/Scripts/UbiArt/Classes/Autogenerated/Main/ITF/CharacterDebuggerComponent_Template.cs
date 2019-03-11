using UnityEngine;

namespace UbiArt.ITF {
	public partial class CharacterDebuggerComponent_Template : ActorComponent_Template {
		[Serialize("showCollider"      )] public bool showCollider;
		[Serialize("showTrajectory"    )] public bool showTrajectory;
		[Serialize("debugController"   )] public bool debugController;
		[Serialize("debugAnim"         )] public bool debugAnim;
		[Serialize("debugAnimInputs"   )] public bool debugAnimInputs;
		[Serialize("debugAI"           )] public bool debugAI;
		[Serialize("debugMaxTrajectory")] public uint debugMaxTrajectory;
		[Serialize("debugSoundInputs"  )] public bool debugSoundInputs;
		[Serialize("debugActorPos"     )] public bool debugActorPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(showCollider));
				SerializeField(s, nameof(showTrajectory));
				SerializeField(s, nameof(debugController));
				SerializeField(s, nameof(debugAnim));
				SerializeField(s, nameof(debugAnimInputs));
				SerializeField(s, nameof(debugAI));
				SerializeField(s, nameof(debugMaxTrajectory));
				SerializeField(s, nameof(debugSoundInputs));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(showCollider));
				SerializeField(s, nameof(showTrajectory));
				SerializeField(s, nameof(debugController));
				SerializeField(s, nameof(debugAnim));
				SerializeField(s, nameof(debugAnimInputs));
				SerializeField(s, nameof(debugAI));
				SerializeField(s, nameof(debugMaxTrajectory));
				SerializeField(s, nameof(debugSoundInputs));
			} else {
				SerializeField(s, nameof(showCollider));
				SerializeField(s, nameof(showTrajectory));
				SerializeField(s, nameof(debugController));
				SerializeField(s, nameof(debugAnim));
				SerializeField(s, nameof(debugAnimInputs));
				SerializeField(s, nameof(debugAI));
				SerializeField(s, nameof(debugMaxTrajectory));
				SerializeField(s, nameof(debugSoundInputs));
				SerializeField(s, nameof(debugActorPos));
			}
		}
		public override uint? ClassCRC => 0x832235B6;
	}
}

