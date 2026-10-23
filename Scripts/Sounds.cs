// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Sounds
using UnityEngine;

public class Sounds : MonoBehaviour
{
	public AudioSource[] Audios;

	[SerializeField]
	public AudioSource mainTheme;

	private void Awake()
	{
		PlayAudio(4);
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PlayAudio(int i)
	{
		Audios[i].Play();
	}
}
