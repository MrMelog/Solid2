using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{

	void Play ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
