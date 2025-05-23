using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer kaynakSpriteRenderer; // Renk alınacak SpriteRenderer
    public SpriteRenderer hedefSpriteRenderer; // Rengin değiştirileceği SpriteRenderer

    private void OnMouseDown()
    {
        if (kaynakSpriteRenderer != null && hedefSpriteRenderer != null)
        {
            hedefSpriteRenderer.color = kaynakSpriteRenderer.color;
        }
    }
}