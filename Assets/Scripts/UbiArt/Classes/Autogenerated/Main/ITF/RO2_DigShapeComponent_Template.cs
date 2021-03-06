using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RL)]
	public partial class RO2_DigShapeComponent_Template : ActorComponent_Template {
		[Serialize("digByDefault"   )] public bool digByDefault;
		[Serialize("digOffset"      )] public Vector2 digOffset;
		[Serialize("digScale"       )] public Vector2 digScale;
		[Serialize("useActorAngle"  )] public bool useActorAngle;
		[Serialize("sendEventToSelf")] public bool sendEventToSelf;
		[Serialize("staticEnabled"  )] public bool staticEnabled;
		[Serialize("staticDuration" )] public float staticDuration;
		[Serialize("digShape"       )] public Generic<PhysShape> digShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(digByDefault), boolAsByte: true);
				SerializeField(s, nameof(digOffset));
				SerializeField(s, nameof(digScale));
				SerializeField(s, nameof(useActorAngle), boolAsByte: true);
				SerializeField(s, nameof(sendEventToSelf), boolAsByte: true);
				SerializeField(s, nameof(staticEnabled));
				SerializeField(s, nameof(staticDuration));
				SerializeField(s, nameof(digShape));
			} else {
				SerializeField(s, nameof(digByDefault));
				SerializeField(s, nameof(digOffset));
				SerializeField(s, nameof(digScale));
				SerializeField(s, nameof(useActorAngle));
				SerializeField(s, nameof(sendEventToSelf));
				SerializeField(s, nameof(staticEnabled));
				SerializeField(s, nameof(staticDuration));
				SerializeField(s, nameof(digShape));
			}
		}
		public override uint? ClassCRC => 0x39406FA0;
	}
}

