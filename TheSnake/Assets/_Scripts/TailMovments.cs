using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailMovments : MonoBehaviour {

	public float Speed;
	public float RotationSpeed;
	public int index;
	public Vector3 tailTarget;
	public SnakeMovement mainSnake;
	public GameObject tailTargetObj;

	void Start()
	{
		mainSnake = GameObject.FindGameObjectWithTag ("SnakeMain").GetComponent<SnakeMovement> ();
		Speed = mainSnake.Speed+1.5f;
		tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
		index = mainSnake.tailObjects.IndexOf (gameObject);
	}

	void Update () {
		tailTarget = tailTargetObj.transform.position;
		transform.LookAt (tailTarget);
		transform.position = Vector3.Lerp (transform.position, tailTarget, Time.deltaTime * Speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("SnakeMain")) {
			if (index > 2) {
				SceneManager.LoadScene ("main");
			}
		}

	}
}
