using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject groundChecker;
    public float maxSpeed = 5.0f;
    public LayerMask whatIsGround;
    bool isOnGround = false;
    // Start is called before the first frame update
    Rigidbody2D playerObject;

    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 

        float movementValueX = Input.GetAxis("Horizontal");
        
        playerObject.velocity = new Vector2 (movementValueX * maxSpeed, playerObject.velocity.y);
        

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.001f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, 500.0f));
        }
            
        
    }

}
