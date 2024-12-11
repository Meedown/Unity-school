using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PBank : MonoBehaviour
{
    public TMP_InputField bankField;
    public int bank;
    // Start is called before the first frame update
    void Start()
    {
        bankField = gameObject.GetComponent<TMP_InputField>();
        bankField.characterLimit = 3;
    }

    // Update is called once per frame
    void Update()
    {
        bankField.text = Convert.ToString(bank);
        //Debug.Log("Text bank: " + bank);
    }
}
