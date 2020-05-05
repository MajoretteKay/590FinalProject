using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
public class TrapStart : MonoBehaviour
{

    public GameObject soundtoPlay;
    public bool alreadyPlayed = false;
    public CharacterController player;
    public GameObject deadwall;
    public GameObject deadwall2;
    // Start is called before the first frame update
  

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other){
        // if(other == player.tag){
            Destroy(deadwall);
            Destroy(deadwall2);
    //     }
    if(!alreadyPlayed){
        soundtoPlay.active = true;
        alreadyPlayed=true;
    }
     }
}
