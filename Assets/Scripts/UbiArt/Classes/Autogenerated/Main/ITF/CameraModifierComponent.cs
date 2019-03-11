using UnityEngine;

namespace UbiArt.ITF {
	public partial class CameraModifierComponent : ActorComponent {
		[Serialize("cameraView"            )] public uint cameraView;
		[Serialize("ignoreAABB"            )] public bool ignoreAABB;
		[Serialize("ignoreSceneActiveState")] public bool ignoreSceneActiveState;
		[Serialize("CM"                    )] public CamModifier CM;
		[Serialize("localAABB"             )] public AABB localAABB;
		[Serialize("CM_override"           )] public Placeholder CM_override;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(CM));
					SerializeField(s, nameof(CM_override));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(cameraView));
					SerializeField(s, nameof(ignoreAABB));
					SerializeField(s, nameof(CM));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(localAABB));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(cameraView));
					SerializeField(s, nameof(ignoreAABB));
					SerializeField(s, nameof(ignoreSceneActiveState));
					SerializeField(s, nameof(CM));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(localAABB));
				}
			}
		}
		public override uint? ClassCRC => 0x6C8DD66E;
	}
}

