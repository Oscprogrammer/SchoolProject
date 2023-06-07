using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Menuscript : MonoBehaviour
{
    public GameObject[] cars;
    public static int carvar = 0;

    public GameObject alertobj;

    public TextMeshProUGUI alert;

    public void quit()
    {
        Application.Quit();
    }

    public void start()
    {
        if (PlayerPrefs.GetInt("Highscore") >= carvar * 10) {
        SceneManager.LoadScene(1);
        }
        else {
            CancelInvoke();
            alertobj.SetActive(true);
            alert.text = "För att låse upp den här bilen måste du ha fått ett high score på minst " + (carvar * 10).ToString();
            Invoke("alerthide",3);
        }
    }

    void alerthide() {
        alertobj.SetActive(false);
    }

    public void change()
    {
        cars[carvar].SetActive(false);
        carvar = (carvar + 1) % cars.Length;
        cars[carvar].SetActive(true);
    }
}