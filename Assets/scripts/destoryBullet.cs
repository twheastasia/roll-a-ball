using UnityEngine;
using System.Collections;

public class destoryBullet : MonoBehaviour {

	public UnityEngine.Object gameobject;
	// Use this for initialization
	void Start () {
		Destroy(gameobject, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
