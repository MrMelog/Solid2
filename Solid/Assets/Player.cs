using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Player : MonoBehaviour
{
	public KeyCode keyOne;
	public KeyCode keyTwo;
	public Vector3 moveDirection;

	private void FixedUpdate()
	{
		if (Input.GetKey(keyOne))
		{
			GetComponent<Rigidbody>().velocity += moveDirection;
		}
		if (Input.GetKey(keyTwo))
		{
			GetComponent<Rigidbody>().velocity -= moveDirection;
		}
		if (Input.GetKey(KeyCode.R))
		{ 
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
	private void OnTriggerEnter(Collider other)
	{
		if (this.CompareTag("Player") && other.CompareTag("Finish"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}

	}
}
