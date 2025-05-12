using UnityEngine;
using TMPro;

public class uimanager : MonoBehaviour
{
    public TextMeshProUGUI themeText; // shows current theme
    public TextMeshProUGUI timerText; // shows timer 

    public void UpdateThemeText(string theme)
    {
        themeText.text = $"Theme: {theme}";
        
    }

    public void UpdateTimer(float time)
    {
        timerText.text = "Time: " + Mathf.Ceil(time).ToString();
    }

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
