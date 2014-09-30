using UnityEngine;
using System.Collections;

public class checkImpact : MonoBehaviour {

	private int shootCounts = 0;
	private int shootOnTargetCounts = 0;
	public GameObject gameobject2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameobject2.transform.position.y < 0) {
			//shootOnTargetCounts = GameObject.Find("Main Camera").GetComponent("moveCamera").shootTargetCounts ++;
			shootOnTargetCounts = moveCamera.shootTargetCounts++;
			GameObject.Find("shootOnTargetCounts").GetComponent("GUIText").guiText.text = "ff "+ shootOnTargetCounts;
		}
	}
}
