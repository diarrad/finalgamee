using UnityEngine;

using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Windows.Speech;


public class ResultSceneManager : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       int score = PlayerPrefs.GetInt("Score", 0); 
       string theme = PlayerPrefs.GetString("Theme", "Unknown");
       bool timedOut = PlayerPrefs.GetInt("TimedOut", 0) == 1;

       string phrase = GetFeedbackPhrase(score);

       resultText.text = (timedOut ? " Time's Up! \n" : " Look Completed!\n") + "Theme: " + theme + "\nScore: " +
                         score + "/4\n\n" + phrase;
    }

    string GetFeedbackPhrase(int score)
    {
        switch (score)
        {
            case 4:
                return " Slayyyy!!!";
            case 3:
                return " Almost! But you ate that ";
            case 2:
                return " Not bad!";
            case 1:
                return "  Umm, maybe next time?";
            default:
                return " Ooohhh, let's try that again ";
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
