using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class carcol : MonoBehaviour
{
    [SerializeField]
    public col gamemanger;

    public AudioSource diesound;

    public CarController carcontroller;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5f) {
            gamemanger.gameoverfunc();
        }
    }
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "enemy") {
            gamemanger.gameoverfunc();
        }
        else if(other.tag == "npc") {
            if (carcontroller.carSpeed > 9) {
                Debug.Log(carcontroller.carSpeed);
            diesound.Play();
            Destroy(other.gameObject);
            gamemanger.generateenemy();
            }
        }
    }
}
