using UnityEngine;
using System.Collections;

public class GoHomeCharlie : MonoBehaviour {

    // start at 

    public Vector2 playerLocation; // location
    public Vector2 homeLocation;
    string distanceFromHome;
    
    // Use this for initialization
    void Start () {
        //playerLocation = new Vector2(2.0f, 3.0f); // Distance in meters
        //homeLocation = new Vector2(0.0f, 0.0f);
        //distanceFromHome = "Distance from home: " + pathToHome.magnitude; // magitude will calculate the vector and return total


        print("Go Home, Charlie!");
        print("...find your way back home.");
        
    }
	
	// Update is called once per frame
	void Update () {

        UpdateMovement(KeyCode.LeftArrow, new Vector2(-1.0f, 0));
        UpdateMovement(KeyCode.RightArrow, new Vector2(1.0f, 0));
        UpdateMovement(KeyCode.UpArrow, new Vector2(0, 1.0f));
        UpdateMovement(KeyCode.DownArrow, new Vector2(0, -1.0f));
        
    }

    private void UpdateMovement(KeyCode keyCode, Vector2 movementVector)
    {
        if (Input.GetKeyDown(keyCode))
        {
            playerLocation = playerLocation + movementVector;
            Print();
        }
    }

    private void Print()
    {
        Vector2 pathToHome = homeLocation - playerLocation;
        print("Distance from home: " + pathToHome.magnitude);

        if (playerLocation == homeLocation)
        {
            print("You're home!");
        }
    }
}
