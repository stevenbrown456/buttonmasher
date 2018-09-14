using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonmasher : MonoBehaviour {
    //data for class
    public AudioSource clickSound; //sound that will play when click button
    public TextMesh scoreText; //display text for score


    private int score = 0; //the numerical data value
    
    // Use this for initialization
	void Start () {
        Debug.Log("start method call");
	} // End of Start()
	
	// Update is called once per frame
	void Update () {
        Debug.Log("end method call");
        //End of update function()

        
    }
    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");

        clickSound.Play(); //Trigger our clicking sound 
        //increase score by 1
        score = score +1;
        //update visual score 
        scoreText.text = score.ToString();
    }
}
//End of ButtonMasher