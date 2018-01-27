﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ecSpawn : MonoBehaviour {


	public GameObject enemigo;
	public Vector3 center;
	public int cantidadObjetos = 1;
	private int creados = 0;
	public Vector2 rangoX;
	public Vector2 rangoY;



	void spawn()
	{
		Vector3 pos;

		pos = center + new Vector3(Random.Range(rangoX.x,rangoX.y), Random.Range(rangoY.x, rangoY.y), 0);
		Instantiate (enemigo, pos, Quaternion.identity);		


	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (creados < cantidadObjetos) 
		{
			spawn ();	
			creados++;
		}

	}
}