using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public int stage;
	public KeyCode Left;
	public KeyCode Right;
	public int Timer;
	public Vector3 stage_1;
	public Vector3 stage_2;
	public GameObject Pers;

	void Awake()
	{
		stage = 1;
	}

    void FixedUpdate()
    {
		if (Timer >= 1)
		{
			Timer = Timer - 1;
		}
		if (Timer == 0)
		{
			if (Input.GetKey(Left) && stage >= 2)
			{
				stage = stage - 1;
				Timer = 50;
				print(stage);
				LvLStage();
			}

			if (Input.GetKey(Right) && stage >= 1)
			{
				stage = stage + 1;
				Timer = 50;
				print(stage);
				LvLStage();
			}
		}

    }


	void LvLStage()
	{
		if (stage == 1)
		{
			Pers.transform.position = stage_1;
		}
		if (stage == 2)
		{
			Pers.transform.position = stage_2;
		}
	}

}
