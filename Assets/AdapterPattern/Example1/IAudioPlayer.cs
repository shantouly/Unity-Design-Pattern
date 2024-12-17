using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AdapaterPattern
{
	/// <summary>
	/// 统一的接口 --- 管理不同类型的音频然后进行播放
	/// </summary>
	public interface IAudioPlayer
	{	
		void Play(string filename);
	}
}
