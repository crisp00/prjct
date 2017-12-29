using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGenerator : MonoBehaviour {

	public Transform world;
	public int size;

	public Transform field, village, water;


	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		
	}

	public void Generate(){
		for(int x = 0; x < size; x++){
			for(int z = 0; z < size; z++){
				float r = Random.value;
				Transform r_;
				if (r < 0.7f) {
					r_ = field;
				} else if (r < 0.95f) {
					r_ = water;
				} else {
					r_ = village;
				}
					
				Transform t = Instantiate (r_, new Vector3(x, 0, z), Quaternion.identity, world);
			}
		}
	}
}
