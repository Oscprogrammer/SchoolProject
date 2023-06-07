using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.AI.Navigation;

public class buildingsscript : MonoBehaviour
{
    [SerializeField]
    private NavMeshSurface surfacenav;
    public GameObject building1;
    public GameObject building2;
    public GameObject building3;
    public GameObject building4;
    public GameObject building5;

    public int length = 5;

    public 

    // Start is called before the first frame update
    void Start()
    {
        generate();
        surfacenav.BuildNavMesh();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void generate() {
    Debug.Log("generate");
    while (transform.childCount > 0) {
    DestroyImmediate(transform.GetChild(0).gameObject);
    }
    for (int i = 0; i < length; i++)
    {
         int random = Random.Range(0,5);
         GameObject currentbuilding = building1; 
        if (random == 0) {
        currentbuilding = building1;
        }
        if (random == 1) {
        currentbuilding = building2;
        }
        if (random == 2) {
        currentbuilding = building3;
        }
        if (random == 3) {
        currentbuilding = building4;
        }
        if (random == 4) {
        currentbuilding = building5;
        }
        Vector3 buildingvector = new Vector3(Random.Range(-60,60), 0,Random.Range(-60,60));
        if (!Physics.CheckBox(buildingvector, new Vector3(7,0,7))) {
        Instantiate(currentbuilding, buildingvector, Quaternion.identity, transform);
        }
        else {
            i = i -1;
        }
    }
    }
}



