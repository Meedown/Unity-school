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
    public int aiChoice() 
    {
        int aiChooses = 0;
        Random.Range(0, 3);
        return aiChooses;

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
        int aiChooses = 0;
        aiChooses = aiChoice();
        if(betField.GetComponent<BettingScript>().UpdatePlayerBet() == false)
        {
            Debug.Log("Invalid bet! Write a number inside the betting field.");
        }
        else
        {
            //Run the game
            Debug.Log("Success! You used " + playerChoice);
        }
        //Sten vs Sax
        if(playerChoice == 0 && aiChooses == 1 )
        {
            playerBank = playerBank + GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
            enemyBank = enemyBank - GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
        }
        // Sax vs Påse
        if (playerChoice == 1 && aiChooses == 2)
        {
            playerBank = playerBank + GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
            enemyBank = enemyBank - GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
        }
        // Påse vs Sten
        if (playerChoice == 2 && aiChooses == 0)
        {
            playerBank = playerBank + GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
            enemyBank = enemyBank - GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
        }
        //Sten vs Påse
        if (playerChoice == 0 && aiChooses == 2)
        {
            playerBank = playerBank - GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
            enemyBank = enemyBank + GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
        }
        //Sax vs Sten
        if (playerChoice == 1 && aiChooses == 0)
        {
            playerBank = playerBank - GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
            enemyBank = enemyBank + GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
        }
        if (playerChoice == 2 && aiChooses == 1)
        {
            playerBank = playerBank - GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
            enemyBank = enemyBank + GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
        }
        if (playerChoice == 0 && aiChooses == 2)
        {
            playerBank = playerBank - GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
            enemyBank = enemyBank + GameObject.FindGameObjectWithTag("BettingButton").gameObject.GetComponent<BettingScript>().bet;
        }
        if (playerChoice == aiChooses)
        {
            Debug.Log("You both chosed the same");
        }

    }
}
