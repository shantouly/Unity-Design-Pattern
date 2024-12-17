using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AdapaterPattern
{
	/// <summary>
	/// audioManager���������Ų�ͬ��Ƶ�Ĺ����ߣ����Բ��õ���ģʽ
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
			// ����MP3���͵���Ƶ
			IAudioPlayer mp3player = new Mp3PlayerAdapter();
			mp3player.Play(TheFilePath.mp3FilePath);
			
			// ����wav���͵���Ƶ
			IAudioPlayer wavPlayer = new WavPlayerAdapter();
			wavPlayer.Play(TheFilePath.wavFilePath);
			
			// ����ogg���͵���Ƶ
			IAudioPlayer oggPlayer = new OOGPlayerAdapter();
			oggPlayer.Play(TheFilePath.oggFilePath);
		}
	}
	
	/// <summary>
	/// ��ͬ������Ƶ�ļ���·��
	/// </summary>
	public class TheFilePath
	{
		public const string mp3FilePath = "Assets/Audio/sample.mp3";
		public const string wavFilePath = "Assets/Audio/sample.wav";
		public const string oggFilePath = "Assets/Audio/sample.ogg";
	}
}

