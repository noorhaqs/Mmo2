using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    //Whole point of this code is to have the ai follow me and shoot at me, and maintain a certain distance from me//
    public float speed;
    public float stoppingDistance;      
    public float retreatDistance;   //also the enemy will retreat//

    public float timeBShots;
    public float StimeBShots;
    public GameObject projectile;

    public Transform player;

 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;   //enemy will not target whoever is a player//
    }

    // Update is called once per frame
    void Update()
    {
     if(Vector2.Distance(transform.position, player.position) > stoppingDistance)   //will check how far the enemy is from the player and then move closer to player depending on it//
    {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }else if(Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)     //if enemy is near then he will stop moving//
        {
            transform.position = this.transform.position;
        }else if(Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime); //if the player comes close to the enemy, then, the enemy will back away//
        }
            
     if(timeBShots <-0)    //makes sure projectiles come after a certain amount of seconds//
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBShots = StimeBShots;   
        }
        else
        {
            timeBShots -= Time.deltaTime;
        }

            }
}
