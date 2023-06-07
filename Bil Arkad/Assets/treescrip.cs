using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treescrip: MonoBehaviour
{



    public GameObject tree1;
    public GameObject tree2;
    public int length = 5;

    public 

    // Start is called before the first frame update
    void Start()
    {
        generatetree();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generatetree() {
    for (int i = 0; i < length; i++)
    {
         int random = Random.Range(0,2);
         GameObject currenttree= tree1; 
        if (random == 0) {
        currenttree = tree1;
        }
        if (random == 1) {
        currenttree = tree2;
        }
        Vector3 buildingvectortree = new Vector3(Random.Range(-90,90), 0,Random.Range(-90,00));
        if (random == 0) {
        if (!Physics.CheckBox(buildingvectortree, new Vector3(4,0,4))) {
        Instantiate(currenttree, buildingvectortree, Quaternion.identity, transform);
        }
        else {
            i = i -1;
        }
        }
        else {
        if (!Physics.CheckBox(buildingvectortree, new Vector3(12,0,12))) {
        Instantiate(currenttree, buildingvectortree, Quaternion.identity, transform);
        }
        else {
            i = i -1;
        }
        }
    }
    }
}
