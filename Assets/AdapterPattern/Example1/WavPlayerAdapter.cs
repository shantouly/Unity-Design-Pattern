using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AdapaterPattern
{
	/// <summary>
	/// ����wav����������ʹ��unity���Դ���audioclip�����в���
	/// </summary>
	public class WavPlayerAdapter : IAudioPlayer
	{
		public void Play(string filename)
		{
			Debug.Log("playing wav !");
			// ����audioclip��ʹ��audioSource�����в���
		}
	}
}

