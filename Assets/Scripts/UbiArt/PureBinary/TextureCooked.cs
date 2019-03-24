﻿using UbiArt.FileFormat.Texture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt {
	public class TextureCooked : ICSerializable {
		public static uint staticSignature = 0x54455800; // TEX\0
		public uint unk;
		public uint signature;
		public uint hdrSize;
		public uint texSize;
		public ushort width;
		public ushort height;
		public ushort unk_x; // tiling flags?
		public ushort unk_y;
		public uint texSize2;
		public uint unk0;
		public uint unk1;
		public uint unk2;
		public uint unk3;
		public uint unk4;
		public uint unk5;
		public byte[] texData;

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref unk);
			s.Serialize(ref signature);
			s.Serialize(ref hdrSize);
			s.Serialize(ref texSize);
			s.Serialize(ref width);
			s.Serialize(ref height);
			s.Serialize(ref unk_x);
			s.Serialize(ref unk_y);
			s.Serialize(ref texSize2);
			s.Serialize(ref unk0);
			s.Serialize(ref unk1);
			s.Serialize(ref unk2);
			s.Serialize(ref unk3);
			s.Serialize(ref unk4);
			s.Serialize(ref unk5);
			s.SerializeBytes(ref texData, (int)texSize);
		}

		private Texture2D texture;
		public Texture2D Texture {
			get {
				if (texture == null && texData != null) {
					//texture = new Texture2D(width, height);
					using (DDSImage dds = new DDSImage(texData)) {
						texture = dds.BitmapImage;
					}
					//texture = LoadTextureDXT(texData);
				}
				return texture;
			}
		}

		private static Texture2D LoadTextureDXT(byte[] ddsBytes) {
			TextureFormat format = TextureFormat.DXT5;
			switch (ddsBytes[87]) { // 84 - 87: DXT1 or DXT5 in ASCII
				case 0x31: // DXT1
					format = TextureFormat.DXT1;
					break;
				case 0x35: // DXT5
					format = TextureFormat.DXT5;
					break;
				default:
					return null;
					Debug.Log("Invalid TextureFormat. Only DXT1 and DXT5 formats are supported by this method.");
					throw new Exception("Invalid TextureFormat. Only DXT1 and DXT5 formats are supported by this method.");
			}

			byte ddsSizeCheck = ddsBytes[4];
			if (ddsSizeCheck != 124)
				throw new Exception("Invalid DDS DXTn texture. Unable to read");  //this header byte should be 124 for DDS image files

			int height = ddsBytes[13] * 256 + ddsBytes[12];
			int width = ddsBytes[17] * 256 + ddsBytes[16];

			int DDS_HEADER_SIZE = 128;
			byte[] dxtBytes = new byte[ddsBytes.Length - DDS_HEADER_SIZE];
			Buffer.BlockCopy(ddsBytes, DDS_HEADER_SIZE, dxtBytes, 0, ddsBytes.Length - DDS_HEADER_SIZE);

			Texture2D texture = new Texture2D(width, height, format, false);
			texture.LoadRawTextureData(dxtBytes);
			texture.Apply();

			return (texture);
		}
	}
}
