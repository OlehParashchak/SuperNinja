using UnityEngine;

public class StarsCollector : MonoBehaviour
{
    public GameObject WinPanel;

    private int starsNum;
    private int currentStarsNum = 0;
    public int levelIndex;


    [SerializeField] private AudioSource starsEfect;
    [SerializeField] private AudioSource finish;

    [SerializeField] GameObject starCollect1;
    [SerializeField] GameObject starCollect2;
    [SerializeField] GameObject starCollect3;

    [SerializeField] GameObject compliteStar1;
    [SerializeField] GameObject compliteStar2;
    [SerializeField] GameObject compliteStar3;

    private bool star1;
    private bool star2;
    private bool star3;

    private void Update()
    {
        StarsCheack();
        StarsCheack2();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Stars"))
        {
            starsEfect.Play();
            Destroy(collision.gameObject);
            starsNum++;
        }
        if(collision.gameObject.name == "Finish")
        {
            Level();
            finish.Play();
            Time.timeScale = 0;
            WinPanel.SetActive(true);

            if (star1)
            {
                compliteStar1.SetActive(true);
            }
            if (star2)
            {
                compliteStar2.SetActive(true);
            }
            if (star3)
            {
                compliteStar3.SetActive(true);
            }
        }
    }
    public void Level()
    {
        currentStarsNum = starsNum;

        if (currentStarsNum > PlayerPrefs.GetInt("Lv" + levelIndex))
        {
            PlayerPrefs.SetInt("Lv" + levelIndex, starsNum);
        }
    }

    private void StarsCheack()
    {
        if (star1)
        {
            starCollect1.SetActive(true);
        }
        if (star2)
        {
            starCollect2.SetActive(true);
        }
        if (star3)
        {
            starCollect3.SetActive(true);
        }
    }
    private void StarsCheack2()
    {
        if (starsNum == 1)
        {
            star1 = true;
        }
        if (starsNum == 2)
        {
            star2 = true;
        }
        if (starsNum == 3)
        {
            star3 = true;
        }
    }
}
