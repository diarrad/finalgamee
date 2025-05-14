using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class challengemanager : MonoBehaviour
{
    public string[] fashionThemes = { "Casual", "Cute", "Edgy", "Formal" }; // possible themes
    public string currentTheme;
    public float timeLimit = 20f;
    private float timer;
    private bool gameEnded = false;
    
    public dressupmanager dressUpManager;
    public uimanager uiManager;
    public AudioClip finishSound;
    public AudioSource sfxSource2;
   
    
    public void GenerateTheme()
    {
        int index = Random.Range(0, fashionThemes.Length); // pick a random theme
        currentTheme = fashionThemes[index];
        uiManager.UpdateThemeText(currentTheme); // show theme in UI

    }

    public void OnFinishClicked()
    {
        
        if(!gameEnded)
        {
            EndGame(false);
        }
        if (finishSound != null && sfxSource2 != null)
        {
            sfxSource2.PlayOneShot(finishSound);
        }
        PlayerPrefs.SetInt("TopIndex", dressUpManager.topIndex);
        PlayerPrefs.SetInt("BottomIndex", dressUpManager.bottomIndex);
        PlayerPrefs.SetInt("HairIndex", dressUpManager.hairIndex);
        PlayerPrefs.SetInt("ShoesIndex", dressUpManager.shoesIndex);
        
    }

    void EndGame(bool timedOut)
    {
        gameEnded = true;
        int score = 0;
        if (dressUpManager.GetTop().styleTag == currentTheme) score++;
        if (dressUpManager.GetBottom().styleTag == currentTheme) score++;
        if (dressUpManager.GetShoes().styleTag == currentTheme) score++;
        if (dressUpManager.GetHair().styleTag == currentTheme) score++;

        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetString("Theme", currentTheme);
        PlayerPrefs.SetInt("TimedOut", timedOut ? 1 : 0);

        SceneManager.LoadScene("ResultScene");
    }

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateTheme();
        timer = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded) return;
        timer -= Time.deltaTime;
        uiManager.UpdateTimer(timer);

        if (timer <= 0f)
        {
            EndGame(timedOut:true);
        }
    }
}
