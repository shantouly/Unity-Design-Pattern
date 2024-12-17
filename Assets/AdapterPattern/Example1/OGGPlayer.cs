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
			// 处理OGG类型的音频
		}
	}
	
	/// <summary>
	/// 播放OGG的适配器
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
