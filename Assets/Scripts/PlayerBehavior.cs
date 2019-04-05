using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    public float Player_speed; //handles how fast player moves//
    public Animator animatorComponent;
    
    float HorizontalMovement = 0f; //initializing movement var//
    float VerticalMovement = 0f; //initializing movement var//


    private Rigidbody2D rb2d;
    private Vector2 moveVel;

    // Start is called before the first frame update
    void Start()
    {
        animatorComponent = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();  

    }

    // Update is called once per frame
    void Update()
    {

        animatorComponent.SetFloat("HSpeed", Mathf.Abs(HorizontalMovement)); //basically connecting the component to script. In this case, I am changing my animations depending on my horizontal and vertical movement//
        animatorComponent.SetFloat("VSpeed", Mathf.Abs(HorizontalMovement));


        HorizontalMovement = Input.GetAxisRaw("Horizontal"); //gets the raw axis so that movement seems more natural//
        VerticalMovement = Input.GetAxisRaw("Vertical");


        Vector2 moveInput = new Vector2(HorizontalMovement, VerticalMovement);  //basically takes input from the user to move the player//
        moveVel = moveInput.normalized * Player_speed;


        if (Input.GetKeyDown(KeyCode.Space)) animatorComponent.SetTrigger("Trigger"); //Space is now the trigger for my attack animation//

    }

    void FixedUpdate()  //everything related to the physics of the game will be here//
    {
        rb2d.MovePosition(rb2d.position + moveVel * Time.fixedDeltaTime);   //in this case, speed//
    }


}
