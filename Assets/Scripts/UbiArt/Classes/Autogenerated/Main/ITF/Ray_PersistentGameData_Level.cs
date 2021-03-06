using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PersistentGameData_Level : PersistentGameData_Level {
		[Serialize("cageMapPassedDoors")] public CArray<PackedObjectPath> cageMapPassedDoors;
		[Serialize("wonChallenges"     )] public uint wonChallenges;
		[Serialize("levelState"        )] public SPOT_STATE levelState;
		[Serialize("bestTimeAttack"    )] public uint bestTimeAttack;
		[Serialize("bestLumAttack"     )] public uint bestLumAttack;
		[Serialize("hasWarning"        )] public bool hasWarning;
		[Serialize("isSkipped"         )] public bool isSkipped;
		[Serialize("trackingdata"      )] public Ray_PersistentGameData_LevelTracking trackingdata;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(cageMapPassedDoors));
			SerializeField(s, nameof(wonChallenges));
			SerializeField(s, nameof(levelState));
			SerializeField(s, nameof(bestTimeAttack));
			SerializeField(s, nameof(bestLumAttack));
			SerializeField(s, nameof(hasWarning));
			SerializeField(s, nameof(isSkipped));
			SerializeField(s, nameof(trackingdata));
		}
		public enum SPOT_STATE {
			[Serialize("SPOT_STATE_CLOSED"      )] CLOSED = 0,
			[Serialize("SPOT_STATE_NEW"         )] NEW = 1,
			[Serialize("SPOT_STATE_CANNOT_ENTER")] CANNOT_ENTER = 2,
			[Serialize("SPOT_STATE_OPEN"        )] OPEN = 3,
			[Serialize("SPOT_STATE_COMPLETED"   )] COMPLETED = 4,
		}
		public override uint? ClassCRC => 0x8729329A;
	}
}

