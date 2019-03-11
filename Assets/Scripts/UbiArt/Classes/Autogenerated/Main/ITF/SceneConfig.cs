using UnityEngine;

namespace UbiArt.ITF {
	public partial class SceneConfig : CSerializable {
		[Serialize("gameModeParametersList")] public CArray<Generic<GameModeParameters>> gameModeParametersList;
		[Serialize("OnEnterFade"           )] public StringID OnEnterFade;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(gameModeParametersList));
			} else {
				SerializeField(s, nameof(gameModeParametersList));
				SerializeField(s, nameof(OnEnterFade));
			}
		}
		public override uint? ClassCRC => 0x8A44E40F;
	}
}

