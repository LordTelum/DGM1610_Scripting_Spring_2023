using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;

    public Transform blaster;
    public GameObject lazerBolt;
    private AudioSource blasterAudio;
    public AudioClip lazerShoot;

    void Start()
    {
        //Get AudioSource component
        blasterAudio = GetComponent<AudioSource>();
    }



    // Update is called once per frame
    void Update()
    {
    // Set's Horizontal input to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

    // Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    //Keeps player within bounds
    //left side wall
        if(transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    //Right side wall
        if(transform.position.x > xRange )
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //If spacebar is pressed fire lazerbolt
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Play lazershoot audio
            blasterAudio.PlayOneShot(lazerShoot, 1.0f);
            //Create Lazerbolt at the blaster transform position maintaining the objects rotation.
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
