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

        // Baþlangýçta hedef Image'ýn rengini kaydet
        targetImage.color = sourceSpriteRenderer.color;
    }

    void Update()
    {
        // Her güncelleme adýmýnda hedef Image'ýn rengini güncelle
        targetImage.color = sourceSpriteRenderer.color;
    }
}

