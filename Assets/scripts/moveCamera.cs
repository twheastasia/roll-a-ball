using UnityEngine;
using System.Collections;

[System.Serializable]
public class moveCamera : MonoBehaviour {

	public int speed = 6;
	public Transform bullet;
	private int count = 0;//the counts of bullets

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//move forward and backward
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		transform.Translate (x, 0, z);

		//fire in the hole
		if (Input.GetButtonDown("Fire1")) {
			Transform tf = (Transform)Instantiate(bullet, transform.position, transform.rotation);
			Vector3 fwd = transform.TransformDirection (Vector3.forward);
			tf.rigidbody.AddForce(fwd * 288);

			count++;
			//gameObject.transform.Find("count").GetComponent(System.GUIText).guiText = "count: " + count;
			GameObject.Find("count").GetComponent("GUIText").guiText.text = "ee "+ count;
		}

		//rotate the camera
		if (Input.GetKey (KeyCode.Q)) {
			transform.Rotate (0, -25 * Time.deltaTime, 0, Space.Self);
		} else if (Input.GetKey (KeyCode.E)) {
			transform.Rotate (0, 25 * Time.deltaTime, 0, Space.Self);
		} else if (Input.GetKey (KeyCode.Z)) {
			transform.Rotate (-25 * Time.deltaTime, 0, 0, Space.Self);
		} else if (Input.GetKey (KeyCode.C)){
			transform.Rotate (25 * Time.deltaTime, 0, 0, Space.Self);
		}


	}
}
