// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// LivesAndScore
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LivesAndScore : MonoBehaviour
{
	[SerializeField]
	public Text vida;

	[SerializeField]
	public Text cantBalloons;

	[SerializeField]
	public Text perdiste;

	[SerializeField]
	public Text ganaste;

	public float cantDardos;

	public float ballonsExplotados;

	private void Start()
	{
		Object.FindObjectOfType<MainTheme>().PlayMusic();
		perdiste.enabled = false;
		ganaste.enabled = false;
		cantDardos = 6f;
		ballonsExplotados = 0f;
	}

	private void Update()
	{
		if (!Perdimos() && !Ganamos())
		{
			vida.text = "X" + cantDardos;
		}
		else
		{
			vida.text = "X" + cantDardos;
			Object.FindObjectOfType<Dardo>().enabled = false;
			MostrarCartelReintentar();
			StartCoroutine(ChequearResultado());
			StartCoroutine(Wait3seconds());
		}
		cantBalloons.text = ballonsExplotados + "/40";
	}

	public void Minus1CantDardos()
	{
		cantDardos--;
	}

	public void SumBallonExplotados()
	{
		ballonsExplotados++;
	}

	public bool Perdimos()
	{
		return cantDardos == 0f;
	}

	public bool Ganamos()
	{
		return ballonsExplotados == 40f;
	}

	public void MostrarCartelReintentar()
	{
		StartCoroutine(Wait3seconds());
	}

	public IEnumerator Wait3seconds()
	{
		yield return new WaitForSeconds(3f);
		CargarMismaEscena();
	}

	public void CargarMismaEscena()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public IEnumerator ChequearResultado()
	{
		yield return new WaitForSeconds(1f);
		if (Ganamos())
		{
			ganaste.enabled = true;
		}
		else
		{
			perdiste.enabled = true;
		}
	}
}
