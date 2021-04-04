using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocity, jumpForce;
    private float velocityPlus=1;
    private Rigidbody rb;
    private bool forward, back, left, right, jump;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void CheckInputs()
    {
        //Ir para frente caso W
        if(Input.GetKey(KeyCode.W)){
            forward= true;
        }
        //Ir para trás caso S
        if(Input.GetKey(KeyCode.S)){
            back = true;
        }
        //Ir para esquerda caso A
        if(Input.GetKey(KeyCode.A)){
            left = true;
        }
        //Ir para direita caso D
        if(Input.GetKey(KeyCode.D)){
            right = true;
        }
        //Pular
        if(Input.GetKeyDown(KeyCode.Space)){
            jump = true;
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            velocityPlus=2;
         }
    }

    void Move()
    {
        //Mover frente
        if(forward){
           rb.AddForce(Vector3.forward*velocity*velocityPlus);
           forward=false;
        }
        //Mover trás
        if(back){
           rb.AddForce(Vector3.back*velocity*velocityPlus);
           back=false;
        }
        //Mover Esquerda
        if(left){
           rb.AddForce(Vector3.left*velocity*velocityPlus);
           left=false;
        }
        //Mover Direita
        if(right){
           rb.AddForce(Vector3.right*velocity*velocityPlus);
           right=false;
        }

        //Pular
        if(jump){
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            jump = false;
        }
        velocityPlus=1;
    }
}
