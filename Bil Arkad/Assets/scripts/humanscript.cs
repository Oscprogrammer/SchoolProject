using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.AI.Navigation;

public class humanscript : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject target;

    public NavMeshSurface surf;

    private Vector3 targetdd;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = targetdd;
        if (this.gameObject.transform.position.x >= targetdd.x - 5 && this.gameObject.transform.position.x <= targetdd.x + 5) {
            if (this.gameObject.transform.position.z >= targetdd.z - 5 && this.gameObject.transform.position.z <= targetdd.z + 5) {
            gentarget();
            }
        }
        if (col.gamemode == 3) {
        GetComponent<NavMeshAgent>().speed = 14;
        }
        else {
            GetComponent<NavMeshAgent>().speed = 5;
        }
    }
    
    public void gentarget() {
        this.gameObject.SetActive(true);
        targetdd = new Vector3(Random.Range(-90,90), 0,Random.Range(-90,90));
        if (Physics.CheckBox(targetdd, new Vector3(1,0,1))) {
            gentarget();
        }

    }

}
