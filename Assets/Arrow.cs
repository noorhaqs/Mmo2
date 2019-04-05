using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D arrowRigidity;
    
    // Start is called before the first frame update
    void Start()
    {
        arrowRigidity.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        Health eneHealth = hit.GetComponent<Health>();
        if(eneHealth != null)
        {
            eneHealth.Damage(50);
        }
        Destroy(gameObject);
    }

}
