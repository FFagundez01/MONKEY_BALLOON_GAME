// Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// NextScene
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
