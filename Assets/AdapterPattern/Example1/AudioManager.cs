using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AdapaterPattern
{
	/// <summary>
	/// audioManager，用来播放不同音频的管理者，可以采用单例模式
	/// </summary>
	public class AudioManager : MonoBehaviour
	{
		private static AudioManager instance;
		public static AudioManager Instance
		{
			get
			{
				return instance;
			}
		}
		
		void Awake()
		{
			if(instance == null)
			{
				instance = this;
			}else
			{
				Destroy(gameObject);
			}
		}
		void Start()
		{
			// 播放MP3类型的音频
			IAudioPlayer mp3player = new Mp3PlayerAdapter();
			mp3player.Play(TheFilePath.mp3FilePath);
			
			// 播放wav类型的音频
			IAudioPlayer wavPlayer = new WavPlayerAdapter();
			wavPlayer.Play(TheFilePath.wavFilePath);
			
			// 播放ogg类型的音频
			IAudioPlayer oggPlayer = new OOGPlayerAdapter();
			oggPlayer.Play(TheFilePath.oggFilePath);
		}
	}
	
	/// <summary>
	/// 不同类型音频文件的路径
	/// </summary>
	public class TheFilePath
	{
		public const string mp3FilePath = "Assets/Audio/sample.mp3";
		public const string wavFilePath = "Assets/Audio/sample.wav";
		public const string oggFilePath = "Assets/Audio/sample.ogg";
	}
}

