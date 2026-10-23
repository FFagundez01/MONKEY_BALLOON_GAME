// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// VelocidadDardo
using UnityEngine;

public class VelocidadDardo : MonoBehaviour
{
	public float velocity;

	public Rigidbody2D rb;

	private void Awake()
	{
		if (Object.FindObjectOfType<ShootDardo>().startTime > 1f)
		{
			velocity = 35f;
			Debug.Log("Fast");
		}
		else if (Object.FindObjectOfType<ShootDardo>().startTime > 0.5f)
		{
			velocity = 28f;
			Debug.Log("Medium");
		}
		else if (Object.FindObjectOfType<ShootDardo>().startTime > 0f)
		{
			velocity = 5f;
			Debug.Log("Slow");
		}
	}

	private void Start()
	{
		rb.AddForce(base.transform.right * velocity, ForceMode2D.Impulse);
	}

	private void Update()
	{
		float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * 57.29578f;
		base.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
	}
}
