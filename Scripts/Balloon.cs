// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Balloon
using UnityEngine;

public class Balloon : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "Dardo")
		{
			base.gameObject.SetActive(value: false);
			Object.FindObjectOfType<LivesAndScore>().SumBallonExplotados();
			Object.FindObjectOfType<Sounds>().PlayAudio(Random.Range(2, 3));
		}
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
