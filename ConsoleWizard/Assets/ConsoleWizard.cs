using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to number wizard\nPick a number and don't tell me what is\nThe highest number you can pick is: " 
            + max + "\nThe lowest is: " + min + "\nTell me if your number is higher or lower than 500\nPush Up = Higher, Push Down = Lower, Push Enter = correct");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            Debug.Log("Up Arrow key was pressed.");

        if (Input.GetKeyDown(KeyCode.DownArrow))
            Debug.Log("Down Arrow key was pressed.");

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("You hit Enter");
    }
}
