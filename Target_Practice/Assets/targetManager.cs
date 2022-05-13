using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class targetManager : MonoBehaviour
{

    //public List<GameObject> targetList;
    public GameObject[] targetList;
    public GameObject txt;
    public int numTarget = 0;
    // Start is called before the first frame update
    void Start()
    {
        targetList = GameObject.FindGameObjectsWithTag("Target");
    }

    // Update is called once per frame
    void Update()
    {      
        /*
        for (int i = targetList.Count-1; i > 0; i--)
        {
            if (targetList[i] == null)
            {
                targetList.RemoveAt(i);
            }
        }
        */
        
        foreach (GameObject t in targetList)
        {
            if (t != null)
            {
                this.numTarget++;
            }
        }

        //string num = ": " + targetList.Count.ToString();
        string num = ": " + numTarget.ToString();
        txt.GetComponentInChildren<Text>().text = num;

        /*
        foreach (GameObject t in targetList)
        {
            Debug.Log(t);
        }
        */

        numTarget = 0;
    }
}
