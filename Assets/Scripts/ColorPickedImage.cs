using UnityEngine;
using UnityEngine.UI;

public class ImageColorChanger : MonoBehaviour
{
    public SpriteRenderer sourceSpriteRenderer;
    public Image targetImage;

    void Start()
    {
        if (sourceSpriteRenderer == null)
        {
            Debug.LogError("Source SpriteRenderer is not assigned!");
            return;
        }

        if (targetImage == null)
        {
            Debug.LogError("Target Image is not assigned!");
            return;
        }

        // Ba�lang��ta hedef Image'�n rengini kaydet
        targetImage.color = sourceSpriteRenderer.color;
    }

    void Update()
    {
        // Her g�ncelleme ad�m�nda hedef Image'�n rengini g�ncelle
        targetImage.color = sourceSpriteRenderer.color;
    }
}

