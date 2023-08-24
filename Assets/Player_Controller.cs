using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    #region Properties
    private Rigidbody rb;
    private Vector3 vectorMove;//вектор который будут прибавлятся к текущей позиции
    private GameObject checkGround;
    [Header("Player Options:")]
    [SerializeField] private float speed;
    [SerializeField] private float forceJump;
    #endregion
    #region StartProgram
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
        rb = gameObject.GetComponent<Rigidbody>();
    }
    #endregion
    #region UpdateAndFixedUpdate
    public void FixedUpdate()
    {
        Move();
    }

    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.name == "Ground")
        {
            Jump();
        }
    }

    public void Move()
    {
        vectorMove = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        gameObject.transform.position += gameObject.transform.TransformVector(vectorMove) * speed / 10;
    }

    public void Jump()
    {
        if(Input.GetKey(KeyCode.Space))
            rb.AddRelativeForce(0, forceJump, 0);
    }
    #endregion
}