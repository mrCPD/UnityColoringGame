using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer kaynakSpriteRenderer; // Renk alýnacak SpriteRenderer
    public SpriteRenderer hedefSpriteRenderer; // Rengin deðiþtirileceði SpriteRenderer

    private void OnMouseDown()
    {
        if (kaynakSpriteRenderer != null && hedefSpriteRenderer != null)
        {
            hedefSpriteRenderer.color = kaynakSpriteRenderer.color;
        }
    }
}