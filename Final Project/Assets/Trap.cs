using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject Special;
    public GameObject Item;
    public AudioSource glassBreak;
    public AudioSource sadTrump;
    public AudioSource winSound;

    // AudioSource sound = glassBreak.GetComponent<AudioSource>();


    void OnTriggerEnter (Collider collision) {
        // if (collision.gameObject.name == "MyGameObjectName")
        if (collision.gameObject.name == "Field 1") {
            Debug.Log("hello");
            Special.GetComponent<MeshRenderer>().enabled = false;
            Special.GetComponent<BoxCollider>().enabled = false;

            glassBreak.Play();
            StartCoroutine(waitPlay());
        } else {
            winSound.Play();
            Destroy(Item);
        }
    }

    IEnumerator waitPlay() {
        yield return new WaitForSeconds(1);
        sadTrump.Play();
    }
}
