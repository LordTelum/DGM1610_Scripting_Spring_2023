using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditionals : MonoBehaviour
{
    int time = 104;

    public string weather = "Clear";

    bool isStopLightRed = true;

    float gpa = 3.25f;

    double temperature = 101.45d;

    string[] enemies = {"Skeleton", "Zombie"};

    // Start is called before the first frame update
    void Start()
    {
        //Check Time
        if(time >= 200)
        {
            Debug.Log("Rise and Shine!");
        }
        else
        {
            Debug.Log("It's too early go back to bed!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Check Weather
        if(weather == "Cloudy")
        {
            Debug.Log("It's cloudy outside");
        }
        else if (weather == "Raining")
        {
            Debug.Log("It's raining outside");
        }
        else if (weather == "Clear")
        {
            Debug.Log("It's a beautiful day outside!");
        }
        else if (weather == "ThunderLightning")
        {
            Debug.Log("There is thunder and lightning outside, stay indoors!!!");
        }
        else if (weather == "snowing")
        {
            Debug.Log("It is snowing outside, bundle up it's clod!");
        }
        else
        {
            Debug.Log("Do what you want! It's a day!");
        }
        
        //Check for enemys
        if (enemy == "Skeleton")
        {
            Debug.Log("There's a skeleton near!");
        }
        else if (enemy == "Zombie")
        {
            Debug.Log("There's Zombies near!");
        }
        else
        {
            Debug.Log("There are no enemys nearby!");
        }
        //Check GPA
        if(gpa >= 3.5)
        {
        Debug.Log("You have a high GPA, keep up the good work!");
        }
        else if(gpa < 3.0)
        {
        Debug.Log("You need to work on your grades.");
        }
        else
        {
        Debug.Log("Your GPA is average, try to improve it.");
        }

        //Check Temperature
        if(temperature >= 100)
        {
        Debug.Log("It's extremely hot outside, stay hydrated and cool!");
        }
        else if(temperature <= 32)
        {
        Debug.Log("It's freezing cold outside, bundle up and stay warm!");
        }
        else
        {
        Debug.Log("The temperature is comfortable, enjoy the weather!");
        }


    }
}
