using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionPlaySet_Template : TweenInstruction_Template {
		[Serialize("set"        )] public StringID set;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(set));
		}
		public override uint? ClassCRC => 0x025C92CF;
	}
}

