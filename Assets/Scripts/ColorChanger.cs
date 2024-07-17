using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer kaynakSpriteRenderer; // Renk al�nacak SpriteRenderer
    public SpriteRenderer hedefSpriteRenderer; // Rengin de�i�tirilece�i SpriteRenderer

    private void OnMouseDown()
    {
        if (kaynakSpriteRenderer != null && hedefSpriteRenderer != null)
        {
            hedefSpriteRenderer.color = kaynakSpriteRenderer.color;
        }
    }
}