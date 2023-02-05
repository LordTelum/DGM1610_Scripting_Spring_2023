using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    
    public int clickToPop = 3; // How Clicks before the balloon pops

    public float scaleToIncrease = 0.10f; // Scale increase each time the ballon is clicked

    public ScoreManager scoreManager; // A reference to the Score manager

    public int scoreToGive =  100;

    // Start is called before the first frame update
    void Start()
    {
        //Get ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        clickToPop --; //Reduce Clicks by one
        //Inflate balloon
        transform.localScale += Vector3.one * scaleToIncrease;
        // Check to see if clickToPop has reached zero. Check to see if the ballon pops
        if(clickToPop == 0)
        {
            //tell the scoremanager to increase the score by a certain amount
            scoreManager.IncreaseScoreText(scoreToGive);

            Destroy(gameObject); //Destroy and remove the popped ballon
        }
    }
}
