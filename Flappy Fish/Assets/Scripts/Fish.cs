using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour {

	[SerializeField]
    private float jumpForce = 500f;
    private Rigidbody2D rb;

    private void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}

    private void Update () {
		if ( Input.GetButtonDown("Fire1")){
			rb.velocity = Vector2.zero;
			rb.AddForce(Vector2.up * jumpForce);
		}

		if (transform.position.y > 8 || transform.position.y < -4)
		{
			SceneManager.LoadScene(0);
		}
	}
}
