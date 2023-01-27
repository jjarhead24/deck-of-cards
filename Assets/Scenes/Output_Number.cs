using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Output_Number : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text Number_text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNumber()
    {
        Number_text.text = "hello world";
    }
}