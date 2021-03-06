using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AILumsComponent : ActorComponent {
		[Serialize("IsTaken"  )] public bool IsTaken;
		[Serialize("initColor")] public Color initColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(IsTaken));
			}
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(initColor));
			}
		}
		public enum Color {
			[Serialize("Color_Yellow")] Yellow = 0,
			[Serialize("Color_Purple")] Purple = 1,
		}
		public override uint? ClassCRC => 0x8519D5E8;
	}
}

