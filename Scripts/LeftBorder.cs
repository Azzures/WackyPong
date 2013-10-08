using UnityEngine;
using System.Collections;

public class LeftBorder : MonoBehaviour {
 
 private bool check = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		Destroy(collision.collider.gameObject);
		check = true;
		Update ();
	}
	
	void OnGUI()

	{
	
	  if (check)
	
	   {
	
	     GUI.Window(0, new Rect((Screen.width/2)-150, (Screen.height/2)-75
	
	            , 300, 250), ShowGUI, "Wacky Pong!");
	
	 
	
	   }

	}
	
	void ShowGUI(int windowID)

     {

         // You may put a label to show a message to the player

 

         GUI.Label(new Rect(65, 40, 200, 30), "Congradats! Player 2 has won");

 

      }
	
}
