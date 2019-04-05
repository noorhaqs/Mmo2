using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{
    public GameObject Enemy;
    private float xVal;
    private float yVal;
    private Vector2 posSpawn;
    public float occurence = 2f;
    private float spawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawn)
        {
            spawn = Time.time + occurence;
            xVal = Random.Range(-3.4f, 3.4f);
            yVal = Random.Range(-3.4f, 3.4f);
            posSpawn = new Vector2(xVal, yVal);
            Instantiate(Enemy, posSpawn, Quaternion.identity);

        }
    }
}
