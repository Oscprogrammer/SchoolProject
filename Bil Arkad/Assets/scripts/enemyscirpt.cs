 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemyscirpt : MonoBehaviour
{

    private Rigidbody enemyrigidbody;

    private Transform playertransform;

    public Plane youdied;

    public NavMeshAgent nav;

    public AudioSource audios;
    // Start is called before the first frame update
    void Start()
    {  
     playertransform = GameObject.FindGameObjectWithTag("player").transform;
     nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.destination = playertransform.position;
        audios.volume = 8/Vector3.Distance(playertransform.position,this.transform.position);
    }

}
