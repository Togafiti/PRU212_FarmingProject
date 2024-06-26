using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    [SerializeField] float speed = 2f;
    Vector2 motionVector;
    Vector2 lastMotionVector;
    Animator animator;
    public bool moving;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizntal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        motionVector = new Vector2(horizntal, vertical);

        animator.SetFloat("horizontal", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("vertical", Input.GetAxisRaw("Vertical"));

        moving = horizntal != 0 || vertical != 0;
        animator.SetBool("moving", moving);

        if (moving)
        {
            lastMotionVector = new Vector2(horizntal, vertical).normalized;
            animator.SetFloat("lastHorizontal", horizntal);
            animator.SetFloat("lastVertical", vertical);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rigidbody2d.velocity = motionVector * speed;
    }
}
