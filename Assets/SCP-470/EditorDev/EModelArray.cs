using UnityEngine;
using System.Collections;

public class EModelArray : MonoBehaviour {
public GameObject model;
public Vector3 offsetrepeat;
public int repeattime;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
	offset = transform.position;
	for (int i = 0; i < repeattime; i++)
		{
			offset += offsetrepeat;
			Instantiate (model, offset, Quaternion.identity);
		}
	}
	
}
