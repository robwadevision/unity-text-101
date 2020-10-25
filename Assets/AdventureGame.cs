using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [ SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "This is the first of many screens you will encounter.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
