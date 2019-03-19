using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class BezierBranchGrowComponent : BezierBranchComponent {
		[Serialize("startCursor"  )] public float startCursor;
		[Serialize("minCursor"    )] public float minCursor;
		[Serialize("maxCursor"    )] public float maxCursor;
		[Serialize("reinitTime"   )] public float reinitTime;
		[Serialize("autoStartTime")] public float autoStartTime;
		[Serialize("growSpeed"    )] public float growSpeed;
		[Serialize("easeMode"     )] public EaseMode easeMode;
		[Serialize("easeMode"     )] public Enum_easeMode easeMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(startCursor));
				SerializeField(s, nameof(growSpeed));
				SerializeField(s, nameof(easeMode));
			} else {
				SerializeField(s, nameof(startCursor));
				SerializeField(s, nameof(minCursor));
				SerializeField(s, nameof(maxCursor));
				SerializeField(s, nameof(reinitTime));
				SerializeField(s, nameof(autoStartTime));
				SerializeField(s, nameof(growSpeed));
				SerializeField(s, nameof(easeMode));
			}
		}
		public enum EaseMode {
			[Serialize("EaseMode_None"     )] None = 0,
			[Serialize("EaseMode_EaseIn"   )] EaseIn = 1,
			[Serialize("EaseMode_EaseOut"  )] EaseOut = 2,
			[Serialize("EaseMode_EaseInOut")] EaseInOut = 3,
		}
		public enum Enum_easeMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x1BCECA5E;
	}
}
