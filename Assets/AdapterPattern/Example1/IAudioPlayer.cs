using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AdapaterPattern
{
	/// <summary>
	/// ͳһ�Ľӿ� --- ����ͬ���͵���ƵȻ����в���
	/// </summary>
	public interface IAudioPlayer
	{	
		void Play(string filename);
	}
}
