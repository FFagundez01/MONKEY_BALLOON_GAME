// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// Dardo
using UnityEngine;

public class Dardo : MonoBehaviour
{
	[SerializeField]
	private Transform aimTransform;

	private void Update()
	{
		Vector3 normalized = (GetMouseWorldPosition() - base.transform.position).normalized;
		float z = Mathf.Atan2(normalized.y, normalized.x) * 57.29578f;
		aimTransform.eulerAngles = new Vector3(0f, 0f, z);
	}

	public static Vector3 GetMouseWorldPosition()
	{
		Vector3 result = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		result.z = 0f;
		return result;
	}
}
