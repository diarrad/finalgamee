using UnityEngine;

public class ResultCharacterDisplay : MonoBehaviour
{
    public SpriteRenderer topRenderer;
    public SpriteRenderer bottomRenderer;
    public SpriteRenderer hairRenderer;
    public SpriteRenderer shoesRenderer;

    public Sprite[] topOptions;
    public Sprite[] bottomOptions;
    public Sprite[] hairOptions;
    public Sprite[] shoesOptions;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int topIndex = PlayerPrefs.GetInt("TopIndex", 0);
        int bottomIndex = PlayerPrefs.GetInt("BottomIndex", 0);
        int hairIndex = PlayerPrefs.GetInt("HairIndex", 0);
        int shoesIndex = PlayerPrefs.GetInt("ShoesIndex", 0);

        topRenderer.sprite = topOptions[topIndex];
        bottomRenderer.sprite = bottomOptions[bottomIndex];
        hairRenderer.sprite = hairOptions[hairIndex];
        shoesRenderer.sprite = shoesOptions[shoesIndex]; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
