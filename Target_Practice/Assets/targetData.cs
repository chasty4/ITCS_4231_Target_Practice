using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetData : MonoBehaviour
{
    public bool isRed;
    public GameObject[] blueOb;
    public float[] movement = {0f, 0f, 0f};
    public bool hasMoved;
    public Vector3 prevPos;


    public void destroy()
    {
        Destroy(gameObject);
    }

    public void destroy(GameObject[] y)
    {
        //Debug.Log(y.name);
        //y.SetActive(!y.activeSelf);

        for (int i = 0; i < y.Length; i++)
        {
            y[i].SetActive(!y[i].activeSelf);
        }

        //y.SetActive(false);
        //Destroy(y);
    }

    public void switchMoved()
    {
        hasMoved = !hasMoved;
    }

    public void moveBlueOb(GameObject ob)
    {
        
        switch (hasMoved)
        {
            case false:
                switchMoved();
                //ob.transform.position = Vector3.MoveTowards(ob.transform.position, ob.GetComponent<bluObHandler>().movedPos, 100f);

                ob.transform.position = ob.GetComponent<bluObHandler>().movedPos;
                
                break;

            case true:
                switchMoved();
                //ob.transform.position = Vector3.MoveTowards(ob.transform.position, ob.GetComponent<bluObHandler>().defaultPos, 100f);
                ob.transform.position = ob.GetComponent<bluObHandler>().defaultPos;
                
                break;
        }

            

        
    }


}
