using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject idol;
    public Light[] lights;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(new Vector3(0.0f,0.0f,7.0f), 2.0f);
        foreach(Collider i in hits) {
            if (i.tag == "Player") {
                lights[0].color = Color.white;
                lights[1].color = Color.white;
                lights[2].color = Color.white;
                Destroy(idol);
            }
        }
    }
}
