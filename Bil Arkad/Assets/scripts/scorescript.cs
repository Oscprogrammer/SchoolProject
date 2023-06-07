using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class scorescript : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI scoredie;

    public TextMeshProUGUI highscore;

    public TextMeshProUGUI gamemodetext;
    // Start is called before the first frame update
    public void AddScore(int score) {
        scoretext.text = "Score: " + score.ToString();
        scoredie.text = "Score: " + score.ToString();
    }
    void Start()
    {
        highscore.text =    "(High score: "  + PlayerPrefs.GetInt("Highscore",0).ToString() + ")";
    }

    public void displaymode() {
        if (col.gamemode == 0 ) {
         gamemodetext.text = "Low Gravity Mode";
        }
        if (col.gamemode == 1) {
            gamemodetext.text = "Slow Motion Mode";
        }
        if (col.gamemode == 2) {
            gamemodetext.text = "The Floor is Ice";
        }
        if (col.gamemode == 3) {
            gamemodetext.text = "Fast Pedestrians Mode";
        }
    }
    public void  clearmode() {
        gamemodetext.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
