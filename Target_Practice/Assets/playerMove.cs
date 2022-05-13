using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{

    public Vector3 vel;
    public bool onGr;

    public CharacterController cont;   
    public float grav = -29.4f;
    public float speed = 10f;
    public Transform grCheck;
    public float grDis = 0.4f;
    public LayerMask grMask;
    public float jHeight = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onGr = Physics.CheckSphere(grCheck.position, grDis, grMask);
        //Debug.Log(onGr);

        if (onGr && vel.y < 0)
        {
            vel.y = -2f;
        }
        Debug.Log(Input.GetKeyDown(KeyCode.Escape));

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        /*
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Hello");
        }
        */
        Vector3 mov = transform.right * x + transform.forward * z;

        cont.Move(mov * speed* Time.deltaTime);



        if (Input.GetButtonDown("Jump") && onGr)
        {
            vel.y += Mathf.Sqrt(jHeight * 2f * grav);
            //Debug.Log(jHeight * 2f * grav);
        }

        vel.y -= grav * Time.deltaTime;

        cont.Move(vel * Time.deltaTime);
    }
}
