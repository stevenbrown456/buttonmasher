using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonmasher : MonoBehaviour
{
    //data for class
    public AudioSource clickSound; //sound that will play when click button
    public TextMesh scoreText; //display text for score
    public TextMesh timerText; //display text for timer
    public float gameLength; // seconds game will last 
    public AudioSource gameoverSound; //sound that will play when game is over
    public TextMesh messageText; //display text message


    private int score = 0; //the numerical data value
    private float timeRemaining = 0;
    private bool gameRunning = false;

    // Use this for initialization
    void Start()
    {
        Debug.Log("start method call");


        
    } // End of Start()

    // Update is called once per frame
    void Update()
    {
        Debug.Log("end method call");
        //numberical time remaining
        timeRemaining = timeRemaining - Time.deltaTime;

        timerText.text = (Mathf.CeilToInt(timeRemaining)).ToString();

        //Check if time has ran out
        if (timeRemaining <= 0)
        {

            if (gameRunning == true)
            {
                gameoverSound.Play();

                //show the player the score
                messageText.text = "time up! Final Score = " + score.ToString();
            }

            gameRunning = false;
            //stop time running negative
            timeRemaining = 0;
        }//End of if (timeRunning <=)



    }  //End of update function()


    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");

        if (gameRunning == true)
        {
            

          clickSound.Play(); //Trigger our clicking sound 
                               //increase score by 1
            score = score + 1;
            //update visual score 
            scoreText.text = score.ToString();

        } //End of if
        else
        {
         gameRunning = true;
            timeRemaining = gameLength;

            messageText.text = "Mash the button";

            //reset the score
            score = 0; 
        }//game is not running
    } // End of OnMouseDown
}    //End of ButtonMasher