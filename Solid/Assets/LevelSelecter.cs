using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelecter : MonoBehaviour
{
	public int levelbox;
	public int stage = 1;
	public int Timer;
	public int levelboxlimit = 10;
	public KeyCode Left;
	public KeyCode Right;
	public KeyCode Up;
	public KeyCode Down;
	public GameObject Pers;
	public int stepscount;
	private float step = 0.569f;
	private int direct;
	public int level;
	public Text SelectText;
	private string lvltext;



	void Awake()
	{
		levelboxlimit = 9;
	}



	void FixedUpdate()
	{
		if (stepscount > 0)
		{
			Pers.transform.Translate(Vector3.forward * step * direct);
			print(stepscount);
			stepscount--;
		}
		if (Timer >= 1)
		{
			Timer = Timer - 1;
		}
		if (Timer == 0)
		{
			if (Input.GetKey(Down) && levelbox < levelboxlimit)
			{
				levelbox = levelbox + 1;
				Timer = 30;
				print(levelbox);
				LvLUp();
			}
			if (Input.GetKey(Up) && levelbox > 0)
			{
				levelbox = levelbox - 1;
				Timer = 25;
				print(levelbox);
				LvLDown();
			}


			if (Input.GetKey(Right))
			{
				level = (levelbox + 1) * 2;
				print(level);
				LvLChange();
				Timer = 50;
			}
			if (Input.GetKey(Left))    
			{
				level = ((levelbox + 1) * 2) - 1;
				print(level);
				LvLChange();
				Timer = 50;
			}   
		}



	}


	void Update()
	{
		lvltext = (((levelbox + 1) * 2) - 1) + "-" + ((levelbox + 1) * 2);
		SelectText.text = "LvL " + lvltext;
	}




	void LvLUp()
	{
		stepscount = 25;
		direct = 1;
	}

	void LvLDown()
	{
		stepscount = 25;
		direct = -1;
	}

	void LvLChange()
	{ 	
		SceneManager.LoadScene(1 + level);
	}




}
