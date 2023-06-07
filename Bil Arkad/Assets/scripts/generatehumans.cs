using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatehumans : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject human;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject r;

    public int length = 5;

    public void genr() {
    for (int i = 0; i < length; i++)
    {
        Vector3 buildingvectorr = new Vector3(Random.Range(-90,90), 0,Random.Range(-90,90));
        if (!Physics.CheckBox(buildingvectorr, new Vector3(3,0,3))) {
        human = Instantiate(r, buildingvectorr, Quaternion.AngleAxis(Random.Range(0f,360f), Vector3.up), transform);
        human.GetComponent<humanscript>().gentarget();
        }
        else {
            i = i -1;
        }
    }
    }
}
