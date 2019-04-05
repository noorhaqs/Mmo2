using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteColor : MonoBehaviour
{

    SpriteRenderer sprite;


    void Start()
    {
        sprite = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        sprite.color = new Color(0,1,0,1);
        
    }
}
