using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerDestroy : MonoBehaviour
{
	void OnCollisionEnter (Collision Destroy)
	{
		print(Destroy.gameObject.tag);

		if (Destroy.gameObject.tag == "Destroy")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

	}
}
