using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
	private ScoreManager scoreManager; // Store reference to score manager
    public int scoreToGive;

	void Start()
	{
		scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // reference ScoreManager
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("LazerBolt"))
        {
            Destroy(gameObject); // destroy this game object
            Destroy(other.gameObject); // destroys the other game object it hits
            //Explosion();
        }
	   scoreManager.IncreaseScore(scoreToGive); // Increase the score
    }
}