using UnityEngine;
using Unity.Collections;
using UnityEngine.InputSystem;
using TMPro;

public class Gameplay : MonoBehaviour
{
    int bossHP = 100;
    int playerHP = 100;
    public Time time;
    TMP_Text bossText;
    TMP_Text playerText;
    public GameObject gameOver;
    public GameObject lose;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bossText = GameObject.Find("BossHP").GetComponent<TMP_Text>();
        playerText = GameObject.Find("PlayerHP").GetComponent<TMP_Text>();



    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && bossHP != 0)
        {
            bossText.text = "Boss HP: " + (bossHP -= 10);
        }

        timesofar = time.time >= 5f;
        if (timesofar && playerHP != 0)
        {
            playerText.text = "Player HP: " + (playerHP -= 10);
        }


        if (bossHP == 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                Time.timeScale = 0f;

            }
        }

        if (playerHP == 0)
        {
            lose.SetActive(true);
            Time.timeScale = 0f;
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                Time.timeScale = 0f;

            }
        }
    }


}
