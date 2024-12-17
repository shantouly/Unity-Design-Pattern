using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AdapaterPattern
{
	/// <summary>
	/// 播放wav的适配器，使用unity中自带的audioclip来进行播放
	/// </summary>
	public class WavPlayerAdapter : IAudioPlayer
	{
		public void Play(string filename)
		{
			Debug.Log("playing wav !");
			// 加载audioclip，使用audioSource来进行播放
		}
	}
}

