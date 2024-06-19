using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    public GameObject objectToEnable; // The game object to enable
    private bool isEnabled = false; // Flag to track the state

    // Start is called before the first frame update
    void Start()
    {
        // Disable the specified game object
        if (objectToEnable != null)
        {
            objectToEnable.SetActive(false);
            Debug.Log("Disabled the object");
        }
        
    }

    // Update is called once per frame
   

    public void OnButtonClick(){
        if(isEnabled == false){
            isEnabled = true;
            objectToEnable.SetActive(true);
    }
        else{
            isEnabled = false;
            objectToEnable.SetActive(false);
        }
    }
}
