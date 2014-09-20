using UnityEngine;
using System.Collections;

[System.Serializable]
public class moveCamera : MonoBehaviour {

	public int speed = 6;
	public Transform bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		transform.Translate (x, 0, z);

		if (Input.GetButtonDown("Fire1")) {
			Transform tf = (Transform)Instantiate(bullet, transform.position, transform.rotation);
			Vector3 fwd = transform.TransformDirection (Vector3.forward);
			tf.rigidbody.AddForce(fwd * 288);
		}
						
	}
}
