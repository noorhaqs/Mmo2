using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public Vector2 speed = new Vector2(8, 8);

    public Vector2 direction = new Vector2(-1, 0);

    
    void update()
    {
        Vector3 move = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);
        move *= Time.deltaTime;
        transform.Translate(move);
    }

    
}
