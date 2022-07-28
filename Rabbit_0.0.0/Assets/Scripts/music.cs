using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    public Sprite enableSprite;
    public Sprite disableSprite;

    bool audioEnabled = true;
    public bool AudioEnabled { get { return audioEnabled; } set { SetAudio(value); } }

    Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    void SetAudio(bool enabled)
    {
        if(!loos.los){
        if (enabled)
        {
            AudioListener.volume = 1f;
            image.sprite = enableSprite;
        }
        else
        {
            AudioListener.volume = 0f;
            image.sprite = disableSprite;
        }
        audioEnabled = enabled;
        }
    }

    public void SwitchAudio()
    {
        AudioEnabled = !AudioEnabled;
    }
}