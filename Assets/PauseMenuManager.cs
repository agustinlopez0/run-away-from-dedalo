using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    public OptionsMenu optionsMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Debug.Log("Escape key pressed");
            optionsMenu.gameObject.SetActive(!optionsMenu.gameObject.activeSelf);
        }
        
    }
}
