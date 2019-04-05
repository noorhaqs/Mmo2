using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShScript : MonoBehaviour
{

    public int damage = 1;
    public bool Enemy = false;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 20);
    }

   
}
