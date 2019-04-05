using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "KBindings", menuName ="Keybindings")]
public class KBindings : ScriptableObject
{
    public KeyCode attack;

    public KeyCode CheckKey(string key)
    {
        if (key == "attack") //checks to make sure the right key is clicked to begin the action//
        {
            return attack;
        }
        else
        {
            return KeyCode.None;
        }
    }


}
