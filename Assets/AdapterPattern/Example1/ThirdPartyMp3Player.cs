using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AdapaterPattern
{
	public class ThirdPartyMp3Player
	{
		public void PlayMp3(string filename)
		{
			Debug.Log("playing MP3 !");
			// 处理mp3类型的音频
		}
	}
	
	/// <summary>
	/// MP3播放适配器
	/// </summary>
	public class Mp3PlayerAdapter : IAudioPlayer
	{
		private ThirdPartyMp3Player mp3Player = new ThirdPartyMp3Player();
		
		public void Play(string filename)
		{
			mp3Player.PlayMp3(filename);	
		}
	}
}

