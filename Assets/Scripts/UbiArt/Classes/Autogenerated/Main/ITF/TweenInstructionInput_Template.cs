using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionInput_Template : TweenInstruction_Template {
		[Serialize("inputName"  )] public StringID inputName;
		[Serialize("floatValue" )] public float floatValue;
		[Serialize("uintValue"  )] public uint uintValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inputName));
			SerializeField(s, nameof(floatValue));
			SerializeField(s, nameof(uintValue));
		}
		public override uint? ClassCRC => 0xAA2BA0F3;
	}
}

