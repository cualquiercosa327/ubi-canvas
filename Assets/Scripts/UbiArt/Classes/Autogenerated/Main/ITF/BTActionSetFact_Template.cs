using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class BTActionSetFact_Template : BTAction_Template {
		[Serialize("fact"     )] public StringID fact;
		[Serialize("value"    )] public string value;
		[Serialize("type"     )] public EValueType type;
		[Serialize("operation")] public SetFactOperationType operation;
		[Serialize("type"     )] public EValueType2 type2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(fact));
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(type2));
			} else {
				SerializeField(s, nameof(fact));
				SerializeField(s, nameof(value));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(operation));
			}
		}
		public enum EValueType {
			[Serialize("EValueType_Unknown"   )] Unknown = 0,
			[Serialize("EValueType_Boolean"   )] Boolean = 1,
			[Serialize("EValueType_Integer32" )] Integer32 = 2,
			[Serialize("EValueType_UInteger32")] UInteger32 = 3,
			[Serialize("EValueType_Float"     )] Float = 4,
			[Serialize("EValueType_StringId"  )] StringId = 5,
			[Serialize("EValueType_Vec2"      )] Vec2 = 6,
			[Serialize("EValueType_Vec3"      )] Vec3 = 7,
			[Serialize("EValueType_ObjectRef" )] ObjectRef = 8,
			[Serialize("EValueType_Event"     )] Event = 9,
		}
		public enum SetFactOperationType {
			[Serialize("SetFactOperationType_Set")] Set = 0,
			[Serialize("SetFactOperationType_Add")] Add = 1,
		}
		public enum EValueType2 {
			[Serialize("EValueType_Boolean"   )] Boolean = 1,
			[Serialize("EValueType_Integer32" )] Integer32 = 2,
			[Serialize("EValueType_UInteger32")] UInteger32 = 3,
			[Serialize("EValueType_Float"     )] Float = 4,
			[Serialize("EValueType_StringId"  )] StringId = 5,
			[Serialize("EValueType_Vec2"      )] Vec2 = 6,
			[Serialize("EValueType_Vec3"      )] Vec3 = 7,
			[Serialize("EValueType_ObjectRef" )] ObjectRef = 8,
			[Serialize("EValueType_Event"     )] Event = 9,
		}
		public override uint? ClassCRC => 0x802B1CD5;
	}
}

