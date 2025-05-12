using UnityEngine;

public class dressupmanager : MonoBehaviour
{
    public SpriteRenderer hairRenderer, topRenderer, bottomRenderer, shoesRenderer; // show current items on character

    public ClothingOption[] hairOptions, topOptions, bottomOptions, shoesOptions; // arrays for all the clothes

    public int hairIndex = 0, topIndex = 0, bottomIndex = 0, shoesIndex = 0; // keep track of selected items
    
    public AudioSource sfxSource;
    public AudioClip changeSound;

    public void NextHair()
    {
        hairIndex = (hairIndex + 1) % hairOptions.Length;
        hairRenderer.sprite = hairOptions[hairIndex].sprite;
        sfxSource.PlayOneShot(changeSound);
    }

    public void NextTop()
    {
        topIndex = (topIndex + 1) % topOptions.Length;
        topRenderer.sprite = topOptions[topIndex].sprite;
        sfxSource.PlayOneShot(changeSound);
    }

    public void NextBottom()
    {
        bottomIndex = (bottomIndex + 1) % bottomOptions.Length;
        bottomRenderer.sprite = bottomOptions[bottomIndex].sprite;
    }

    public void NextShoes()
    {
        shoesIndex = (shoesIndex + 1) % shoesOptions.Length;
        shoesRenderer.sprite = shoesOptions[shoesIndex].sprite;
    }
    public ClothingOption GetHair() => hairOptions[hairIndex];

    public ClothingOption GetTop() => topOptions[topIndex];
    
    public ClothingOption GetBottom() => bottomOptions[bottomIndex];
    
    public ClothingOption GetShoes() => shoesOptions[shoesIndex];
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
