using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using System.Collections.Generic;

public class SnakeMovement : MonoBehaviour {

	public float Speed;
	public float RotationSpeed;
	public int size = 0;
	// public GameObject[] tailObjects = new GameObject[1];
	public GameObject TailPrefab;

	public List<GameObject> tailObjects = new List<GameObject> ();

	public Text ScoreText;
	public int score = 0;

	// Use this for initialization
	void Start () {
		tailObjects.Add (gameObject);
	}
	
	// Update is called once per frame
	void Update () {

		ScoreText.text = score.ToString ();
		transform.Translate (Vector3.forward * Speed * Time.deltaTime);

		if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate (Vector3.up*RotationSpeed*Time.deltaTime);
		} 
		else if (Input.GetKey(KeyCode.A)) 
		{
			transform.Rotate (Vector3.down*RotationSpeed*Time.deltaTime);
		}

	}

	public void AddTail()
	{
		Vector3 newTailPos = tailObjects [tailObjects.Count - 1].transform.position;
		tailObjects.Add(GameObject.Instantiate (TailPrefab, newTailPos, Quaternion.identity) as GameObject);
		score++;
	}
}
