using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareEvent : MonoBehaviour
{
    public Light[] lights;
    public GameObject idol;
    public GameObject scare;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Collider[] hitColliders = Physics.OverlapSphere(new Vector3(0f, 1.5f, 0f), 1.0f);
         foreach(Collider i in hitColliders) {
             if (i.tag == "Player") {
                 Event();

             }
         }
    }

    void Event() {
        foreach(Light light in lights) {
            light.color = Color.red;
        }
        scare.active = true;
        
    }
}
