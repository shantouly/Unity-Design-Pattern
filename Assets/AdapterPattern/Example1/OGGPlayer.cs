using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AdapaterPattern
{
	public class OGGPlayer
	{
		public void PlayOGGFile(string filename)
		{
			Debug.Log("playing the OGG file!");
			// ����OGG���͵���Ƶ
		}
	}
	
	/// <summary>
	/// ����OGG��������
	/// </summary>
	public class OOGPlayerAdapter : IAudioPlayer
	{
		private OGGPlayer oGGPlayer = new OGGPlayer();
		public void Play(string filename)
		{
			oGGPlayer.PlayOGGFile(filename);
		}
	}
}
