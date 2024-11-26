using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButtons : MonoBehaviour
{
    [Header("Interactable Buttons")]
    public Button rockButton;
    public Button paperButton;
    public Button scissorButton;

    private GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //When a button is pressed it will call on its corresponding function to do something!
        rockButton.onClick.AddListener(ChooseRock);
        paperButton.onClick.AddListener(ChoosePaper);
        scissorButton.onClick.AddListener(ChooseScissor);

        //Store the game's manager in the gameManager GameObject. The object's name you can find within the Hierarchy of the editor itself.
        gameManager = GameObject.Find("GameManager"); 

        //If something went wrong the following error code will run.
        if (gameManager == null)
        {
            Debug.Log("The Game Manager was not properly stored! Check if the string corresponds with the name of the Game Object in the editor's hierarchy");
        }
    }

    //Below are functions for each option.
    private void ChooseRock()
    {
        //Communicate with the Game Manager using Unity's GetComponent function.
    }

    private void ChoosePaper()
    {
        //Communicate with the Game Manager
    }

    private void ChooseScissor()
    {
        //Communicate with the Game Manager
    }
}
