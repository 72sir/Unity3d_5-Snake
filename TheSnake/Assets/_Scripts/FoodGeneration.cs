using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour {

	public float XSize = 8.5f;
	public float ZSize = 8.5f;

	public GameObject foodPrefab;
	public GameObject curFood;

	public Vector3 curPos;

	// Use this for initialization
	void Start () {

		
	}

	void RandomPosition()
	{
		curPos = new Vector3 (Random.Range(XSize*-1, XSize), 0.25f, Random.Range(ZSize*-1, ZSize));
	}

	void AddNewFood()
	{
		RandomPosition ();
		curFood = GameObject.Instantiate (foodPrefab, curPos, Quaternion.identity) as GameObject;
	}

	// Update is called once per frame
	void Update () {
		if (!curFood) {
			AddNewFood ();
		}
	}
}
