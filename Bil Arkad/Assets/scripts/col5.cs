using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col5 : MonoBehaviour
{
    public GameObject buildingsobject;
    
    buildingsscript generate;
    // Start is called before the first frame update
    void Start()
    {
        generate = buildingsobject.GetComponent<buildingsscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}