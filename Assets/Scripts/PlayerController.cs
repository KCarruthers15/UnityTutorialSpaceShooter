using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
    
    public float speed;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		rb.velocity = (new Vector3(moveHorizontal, 0.0f, moveVertical)) * speed;
        
        
      //  rb.position = new Vector3(x, 0, z);  
	}
}
