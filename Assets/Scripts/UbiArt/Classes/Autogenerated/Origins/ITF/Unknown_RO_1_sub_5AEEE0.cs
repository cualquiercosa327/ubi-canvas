using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_RO_1_sub_5AEEE0 : CSerializable {
		[Serialize("isMecha"       )] public bool isMecha;
		[Serialize("playIntroMusic")] public bool playIntroMusic;
		[Serialize("playIntro"     )] public bool playIntro;
		[Serialize("tailDelay"     )] public float tailDelay;
		[Serialize("egg"           )] public Path egg;
		[Serialize("eggBone"       )] public StringID eggBone;
		[Serialize("nbEggs"        )] public uint nbEggs;
		[Serialize("firstEggDelay" )] public float firstEggDelay;
		[Serialize("eggDelay"      )] public float eggDelay;
		[Serialize("bird"          )] public Path bird;
		[Serialize("nbBirds"       )] public uint nbBirds;
		[Serialize("birdYStart"    )] public float birdYStart;
		[Serialize("birdYLow"      )] public float birdYLow;
		[Serialize("birdXOffset"   )] public float birdXOffset;
		[Serialize("birdXSpace"    )] public float birdXSpace;
		[Serialize("birdYSpace"    )] public float birdYSpace;
		[Serialize("maxLums"       )] public uint maxLums;
		[Serialize("musics"        )] public Placeholder musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isMecha));
			SerializeField(s, nameof(playIntroMusic));
			SerializeField(s, nameof(playIntro));
			SerializeField(s, nameof(tailDelay));
			SerializeField(s, nameof(egg));
			SerializeField(s, nameof(eggBone));
			SerializeField(s, nameof(nbEggs));
			SerializeField(s, nameof(firstEggDelay));
			SerializeField(s, nameof(eggDelay));
			SerializeField(s, nameof(bird));
			SerializeField(s, nameof(nbBirds));
			SerializeField(s, nameof(birdYStart));
			SerializeField(s, nameof(birdYLow));
			SerializeField(s, nameof(birdXOffset));
			SerializeField(s, nameof(birdXSpace));
			SerializeField(s, nameof(birdYSpace));
			SerializeField(s, nameof(maxLums));
			SerializeField(s, nameof(musics));
		}
		public override uint? ClassCRC => 0x804D1AAC;
	}
}

