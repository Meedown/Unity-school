using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BettingScript : MonoBehaviour
{

    public TMP_InputField betField;
    public int bet;

    // Start is called before the first frame update
    void Start()
    {
        betField = gameObject.GetComponent<TMP_InputField>();
        betField.characterLimit = 3;
    }

    public bool UpdatePlayerBet()
    {
        string inputField = betField.text;
        if (int.TryParse(inputField, out int value))
        {
            bet = value;
            return true;
        }
        else
        {
            return false;
        }


        
    }
}
