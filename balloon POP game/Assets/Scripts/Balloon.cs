using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    
    public int clickToPop = 3; // How Clicks before the balloon pops

    public float scaleToIncrease = 0.10f; // Scale increase each time the ballon is clicked

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        clickToPop --; //Reduce Clicks by one
        //Inflate balloon
        transform.localScale += Vector3.one * scaleToIncrease;
        // Check to see if clickToPop has reached zero. Check to see if the ballon pops
        if(clickToPop == 0)
        {
            Destroy(gameObject); //Destroy and remove the popped ballon
        }



    }
}
