using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buffalo : MonoBehaviour
{
    private Rigidbody2D rigid;
    public static bool gamePause = true;
    public float highb;
    public GameObject gameOverObj;
    public GameObject pauseMenu;
    public GameObject startMenu;

    void Start()
    {
        startMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Start2()
    {
        startMenu.SetActive(false);
        Time.timeScale = 1f;
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.A))
        {
            rigid.AddForce(Vector2.up * highb);
        }

        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePause)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Gameover();
    }
    void Gameover()
    {
        gameOverObj.SetActive(true);
        Time.timeScale = 0;
    }

    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gamePause = true;
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gamePause = false;
    }
}
