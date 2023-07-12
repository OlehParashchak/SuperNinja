using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public InterstitialAds ad;

    public void Pause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        ad.ShowAd();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    public void Restart()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +0);
    }
    public void NextLevel(int previousLevelNum)
    {
        SceneManager.LoadScene(previousLevelNum);
        Time.timeScale = 1;
    }
}
