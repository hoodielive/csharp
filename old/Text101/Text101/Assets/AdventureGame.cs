using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    int[] oddNumbers = { 1, 3, 5, 7, 9 };

    State state; 
    
    void Start()
    {
        /** textComponent.text = ("Placeholder ipsum loren the fore this bacground text should be goin on the canvas " +
              "and lets see the image of the more hightPlaceholder ipsum loren the fore this bacground text should " +
              "be goin on the canvas and lets see the image of the more hight Placeholder ipsum loren the fore this " +
              "bacground text should be goin on the canvas and lets see the image of the more hight Placeholder ipsum " +
              "loren the fore this bacground text should be goin on the canvas and lets see the image of the more hight " +
              "Placeholder ipsum loren the fore this bacground text should be goin on the canvas and lets see the image of" +
              " the more hight Placeholder ipsum loren the fore this bacground text should be goin on the canvas and lets " +
              "see the image of the more hight");
     */

        state = startingState;
        textComponent.text = state.GetStateStory();
            
    }

    void Update()
    {
        ManageState(); 
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0]; 
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1]; 
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2]; 
        }
        textComponent.text = state.GetStateStory(); 
    }
}
