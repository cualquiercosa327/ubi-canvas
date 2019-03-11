using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenWait : TweenInstruction {
		[Serialize("name")] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
			} else {
			}
		}
		public override uint? ClassCRC => 0xB5E28870;
	}
}

