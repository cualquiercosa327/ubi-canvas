using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_GameGlobalsRegionCondition : online.GameGlobalsCondition {
		[Serialize("region")] public RLC_GraphicalFamily region;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(region));
		}
		public enum RLC_GraphicalFamily {
			[Serialize("RLC_GraphicalFamily_Unknown"      )] Unknown = 0,
			[Serialize("RLC_GraphicalFamily_Shaolin"      )] Shaolin = 1,
			[Serialize("RLC_GraphicalFamily_Medieval"     )] Medieval = 2,
			[Serialize("RLC_GraphicalFamily_ToadStory"    )] ToadStory = 3,
			[Serialize("RLC_GraphicalFamily_Desert"       )] Desert = 4,
			[Serialize("RLC_GraphicalFamily_UnderWater"   )] UnderWater = 5,
			[Serialize("RLC_GraphicalFamily_Greece"       )] Greece = 6,
			[Serialize("RLC_GraphicalFamily_LandOfTheDead")] LandOfTheDead = 7,
			[Serialize("RLC_GraphicalFamily_Intro"        )] Intro = 8,
			[Serialize("RLC_GraphicalFamily_Count"        )] Count = 9,
		}
		public override uint? ClassCRC => 0xDBE8F70B;
	}
}

