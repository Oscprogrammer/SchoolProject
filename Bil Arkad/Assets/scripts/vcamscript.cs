using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class vcamscript : MonoBehaviour
{
    public col carsarray;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CinemachineVirtualCamera>().Follow = carsarray.cars[Menuscript.carvar].transform;
        GetComponent<CinemachineVirtualCamera>().LookAt = carsarray.cars[Menuscript.carvar].transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
