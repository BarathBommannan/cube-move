using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    bool moveleft;
    bool moveright;
    float horizaontalmove;

    public float speed=300;


    void Start() 
    {
        rb=GetComponent<Rigidbody>();
    }
    
    public void PointerDownLeft()
    {
        moveleft=true;
    }
    public void PointerUpLeft()
    {
        moveleft=false;
    }
    public void PointerDownRight()
    {
        moveright=true;
    }
    public void PointerUpRight()
    {
        moveright=false;
    }

    private void Update() {
        Movement();
    }

    public void Movement()
    {
        if(moveleft)
        {
            horizaontalmove=-speed;
        }
        else if(moveright)
        {
            horizaontalmove=speed;
        }
        else{
            horizaontalmove=0;
        }
    }

    private void FixedUpdate() {
        rb.velocity=new Vector3(horizaontalmove*Time.deltaTime,rb.velocity.y,rb.velocity.z);
    }
}
