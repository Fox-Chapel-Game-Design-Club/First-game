<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
     private Vector2 movementDirection;
     private Rigidbody2D rb;
     private float moveSpeed; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
     movementDirection = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));

    }

    void FixedUpdate(){
        rb.velocity = movementDirection*moveSpeed;
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
>>>>>>> Stashed changes
