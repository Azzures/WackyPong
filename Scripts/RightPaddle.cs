using UnityEngine;
using System.Collections;

public class RightPaddle : MonoBehaviour {

	private float speed = 0.1f;
 
    // Use this for initialization
    void Start ()
    {
 
    }
 
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            this.transform.position += Vector3.up * speed;
        if (Input.GetKey(KeyCode.DownArrow))
            this.transform.position += Vector3.down * speed;
	}
}
