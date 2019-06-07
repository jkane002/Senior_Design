using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    public  GameObject player;
    private string sceneName;
    public float bar_display;
    public static float width_health = 0.40f;
    private static int pad = (int)(Screen.width * width_health);
    private Vector2 pos = new Vector2(pad,40);
    private Vector2 size = new Vector2(Screen.width - (2 * pad), 20);
    public Texture2D emptyTex;
    public Texture2D fullTex;
    public float Health;
    private GUIStyle currentStyle = null;
    public int score;

    public Text timerText;
    public float startTime;

    public Text countText;

    public GameObject pauseMenuUI;
    public GameObject gameOverMenuUI;
    [SerializeField] private bool isPaused;

    #region Singleton
    public static PlayerManager instance;

    private void Awake()
    {
        instance = this;
        Health = 100;
        Object.DontDestroyOnLoad(this.gameObject);
    }
    #endregion

    void Start()
    {
        pauseMenuUI = GameObject.Find("GUI/PauseMenu");
        gameOverMenuUI = GameObject.Find("GUI/GameOver");
        player = GameObject.FindWithTag("Player");
        timerText = GameObject.Find("GUI/Time").GetComponent<Text>();
        countText = GameObject.Find("GUI/Score").GetComponent<Text>();
        pauseMenuUI.SetActive(false);
        gameOverMenuUI.SetActive(false);

        startTime = Time.time;
        Health = 100;
        bar_display = Health;
        currentStyle = null;

    }

    private void Update()
    {
        bar_display = Health;
        Debug.Log("Health " + Health);
        time();
        setCountText();

        if(Health < 0)
        {
            GameOver();
        }

        if (Input.GetKeyDown("escape"))
        {
            isPaused = !isPaused;
        }

        if(isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeActivateMenu();
        }
    }
    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

    public void DeActivateMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        gameOverMenuUI.SetActive(true);
        Health = 100;
    }

    public void DeActivateGameOver()
    {
        gameOverMenuUI.SetActive(false);
        Time.timeScale = 1;
        AudioListener.pause = false;
        isPaused = false;
        Health = 100;

    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void OnGUI()
    {
        //InitStyles();
        //GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
        //    GUI.Box(new Rect(0, 0, size.x, size.y), emptyTex);
        //    GUI.BeginGroup(new Rect(0, 0, size.x * (bar_display * .01f), size.y),currentStyle);
        //        GUI.Box(new Rect(0, 0, size.x, size.y), fullTex);
        //    GUI.EndGroup();
        //GUI.EndGroup();
    }

    private void InitStyles()
    {
        if (currentStyle == null)
        {
            currentStyle = new GUIStyle(GUI.skin.box);
            currentStyle.normal.background = MakeTex(2, 2, new Color(0f, 1f, 0f, 0.5f));
        }

        if(bar_display < 50 && currentStyle != null)
        {
            currentStyle = new GUIStyle(GUI.skin.box);
            currentStyle.normal.background = MakeTex(2, 2, Color.red);
        }
    }

    private Texture2D MakeTex(int width, int height, Color col)
    {
        Color[] pix = new Color[width * height];
        for (int i = 0; i < pix.Length; ++i)
        {
            pix[i] = col;
        }
        Texture2D result = new Texture2D(width, height);
        result.SetPixels(pix);
        result.Apply();
        return result;
    }

    private void time()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds;

        if (minutes == "0")
        {
            seconds = (t % 60).ToString("f1");
            timerText.text = seconds + "s";
        }
        else
        {
            seconds = (t % 60).ToString("f0");

            if (t % 60 <= 9)
            {
                seconds = '0' + seconds;
            }
            timerText.text = minutes + "." + seconds;
        }
    }

    void setCountText()
    {
        countText.text = "Score: " + score.ToString();
    }
}
