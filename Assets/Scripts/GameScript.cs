using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    public int playerBank = 100;
    public int enemyBank = 100;
    public GameObject betField;


    // Start is called before the first frame update
    void Start()
    {
        //Fetch the GameObject
        betField = GameObject.Find("BettingField");

        //If something went wrong the following error code will run.
        if (betField == null)
        {
            Debug.Log("The Betting Field was not properly stored! Check if the string corresponds with the name of the Game Object in the editor's hierarchy");
        }
    }

    public void GamePlay(int playerChoice)
    {
        //Check whether the player has made a valid bet by communicating with the GameObject holding the BettingScript.
        //The logic looks like this:
        //1.    betField is the name of the GameObject class that will hold the BettingField. 
        //      In simpler terms; betField is where we store the BettingField.
        //2.    We use "GetComponent" to fetch the script from the GameObject
        //3.    We call on the function "UpdatePlayerBet()" within the BettingScript.
        //      This function automatically returns a bool; a true or false. 
        //      If this bool is false the game will not run. 
        if(betField.GetComponent<BettingScript>().UpdatePlayerBet() == false)
        {
            Debug.Log("Invalid bet! Write a number inside the betting field.");
        }
        else
        {
            //Run the game
            Debug.Log("Success! You used " + playerChoice);
        }
    }
}
