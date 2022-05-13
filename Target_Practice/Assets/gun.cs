using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class gun : MonoBehaviour
{
    public AudioSource gunSound;

    public Camera cam;
    public ParticleSystem flash;
    public GameObject impact;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !pauseMenu.paused)
        {
            shoot();
            gunSound.Play();
        }

        void shoot()
        {
            flash.Play();

            RaycastHit hit;
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
            {
                //Debug.Log(hit.transform.tag);
                GameObject eff = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(eff, .6f);

                targetData t = hit.transform.GetComponent<targetData>();
                if (t != null)
                {
                    switch (t.isRed)
                    {
                        case true:
                            t.destroy();
                            break;
                        case false:
                            if (t.blueOb != null)
                            {
                                t.destroy(t.blueOb);
                            }
                            
                            break;
                    }

                    
                }

                
            }
        }

    }
}
