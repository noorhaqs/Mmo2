using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager oneInstance;

    public KBindings keybindings;

    void There()
    {
        if(oneInstance == null)
        {
            oneInstance = this;
        }
        else if (oneInstance != this)
        {
            Destroy(this);
        }
        DontDestroyOnLoad(this);   //There to make sure the input manager stays throughout the entire simgleplayer game//
    }
     public bool KeyDown(string key)
    {
        if (Input.GetKeyDown(keybindings.CheckKey(key)))
        {
            return true;
        }else{
            return false;
        }
    }
}
