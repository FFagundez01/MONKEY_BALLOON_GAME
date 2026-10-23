// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// ShootDardo
using UnityEngine;

public class ShootDardo : MonoBehaviour
{
	public Transform firePoint;

	public GameObject bulletPrefab;

	private Vector3 startPoint;

	private Vector3 endPoint;

	private Camera cam;

	public float startTime;

	private bool pressed;

	public Animator a;

	private void Start()
	{
		cam = Camera.main;
	}

	private void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			pressed = true;
			a.SetBool("Clicking", pressed);
		}
		if (pressed)
		{
			startTime += Time.deltaTime;
		}
		if (Input.GetButtonUp("Fire1") && !Object.FindObjectOfType<LivesAndScore>().Perdimos())
		{
			Shoot();
			Object.FindObjectOfType<Sounds>().PlayAudio(1);
			startTime = 0f;
			pressed = false;
			a.SetBool("Clicking", pressed);
			Object.FindObjectOfType<LivesAndScore>().Minus1CantDardos();
		}
		if (Object.FindObjectOfType<LivesAndScore>().Perdimos())
		{
			a.enabled = false;
		}
	}

	private void Shoot()
	{
		Object.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
	}
}
