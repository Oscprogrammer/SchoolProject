using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
using Unity.AI.Navigation;

public class col : MonoBehaviour
{
    public GameObject[] cars;

    public static int gamemode = 0;

    [SerializeField]
    private GameObject enemy;

     [SerializeField]
     private scorescript ui;

    [SerializeField]
     private GameObject gameover;
     [SerializeField]
     private NavMeshSurface surf;
        [SerializeField]
     private generatehumans genhuman;

     private int setactiveint = 0;

     private int nodouble = 0;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        cars[Menuscript.carvar].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void restart() {
        AudioListener.volume = 1;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void gameoverfunc() {
        if (score > PlayerPrefs.GetInt("Highscore",0)) {
            PlayerPrefs.SetInt("Highscore", score);
        }
        gameover.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.volume = 0;
    }

    public void resetgamemode() {
        Time.timeScale = 1f;
        if (gamemode == 0) {
            cars[Menuscript.carvar].GetComponent<Rigidbody>().mass = cars[Menuscript.carvar].GetComponent<Rigidbody>().mass * 2f;
        }
        gamemode = 0;
        nodouble = 0;
        ui.clearmode();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "player") {
        Vector3 random = new Vector3(Random.Range(-90,90), 2,Random.Range(-90,90));
        if (!Physics.CheckBox(random, new Vector3(5,0,5))) {
            gameObject.transform.position = random;
            score = score + 1;
            ui.AddScore(score);
            if (score == 1) {
                genhuman.genr();
            }
            else if (score == 2) {
                genhuman.genr();
            }
            if (score%5 == 0) {
                generateenemy();
            }
            if (score > 1) {
            int havegamemode = 1;
            if (havegamemode == 1 && nodouble == 0) {
            Debug.Log("gamemmodespecial");
            gamemode = Random.Range(0,3);
            if (gamemode == 0) {
                Debug.Log("Lowgrav");
                cars[Menuscript.carvar].GetComponent<Rigidbody>().mass = cars[Menuscript.carvar].GetComponent<Rigidbody>().mass * 0.1f;
                nodouble = 1;
                Invoke("resetgamemode",10);
                ui.displaymode();
            }
            if (gamemode == 1) {
                Debug.Log("slowmo");
                Time.timeScale = 0.5f;
                nodouble = 1;
                Invoke("resetgamemode",10);
                ui.displaymode();
            }
            if (gamemode == 2) {
                Debug.Log("ice");
                nodouble = 1;
                Invoke("resetgamemode",10);
                ui.displaymode();
            }
            if (gamemode == 3) {
                nodouble = 1;
                Invoke("resetgamemode",10);
                ui.displaymode();
            }
            }
            }
        }
        else {
            OnTriggerEnter(other);
        }
}
}
    public void generateenemy() {
            Vector3 randomvector = new Vector3(Random.Range(-90,90), 0,Random.Range(-90,90));
            if (!Physics.CheckBox(randomvector, new Vector3(4,0,4))) {
            if (setactiveint == 0 ) {
                enemy.SetActive(true);
                setactiveint = 1;
            }
            else {
            Instantiate(enemy, randomvector, Quaternion.identity);
            surf.BuildNavMesh();
            }
            }
            else {
                generateenemy();
            }
    }
}
