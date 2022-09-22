using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject groundChecker;
    public float maxSpeed = 30.0f;
    public LayerMask whatIsground;
    float jumpForce = 300.0f;
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
        if (Input.GetKey(KeyCode.LeftShift))
        {
                maxSpeed = 30.0f;
        }else
        {
            maxSpeed = 20.0f;
        }
        
        float movementValueX = Input.GetAxis("Horizontal");
        playerObject.velocity = new Vector2 (movementValueX, playerObject.velocity.y);

        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsground);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, jumpForce));
        }
            
        
    }

}
