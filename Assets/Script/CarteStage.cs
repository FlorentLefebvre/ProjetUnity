﻿using UnityEngine;
using System.Collections;

public class CarteStage : MonoBehaviour {
	


	private ExplosionBombe _exploBombe1;


	
	
	private GameObject Bombe;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		foreach (var gameObjBombe in FindObjectsOfType(typeof(GameObject)) as GameObject[])
		{
			if(gameObjBombe.name == "Bombe")
			{
				_exploBombe1 = gameObjBombe.GetComponent<ExplosionBombe>();
				if( _exploBombe1.Boom && !(_exploBombe1.Exploded) )
				{

					foreach (var gameObjCube in FindObjectsOfType(typeof(GameObject)) as GameObject[])
					{
					    if(gameObjCube.name == "Cube")
					    {
							float x = Mathf.Abs(gameObjCube.transform.position.x - gameObjBombe.transform.position.x), 
							y = Mathf.Abs(gameObjCube.transform.position.x - gameObjBombe.transform.position.x) ,
							z = Mathf.Abs(gameObjCube.transform.position.x - gameObjBombe.transform.position.x);
					       if( x <= 3 &&  y <= 3 &&  z <= 3)
							{
								
							}
					    }
					}
				}
				
			}
		}

	}
	
	 bool CountCBoom()
    {

		return false;
    }

}
