using UnityEngine;

public class ColorPicMenu : MonoBehaviour
{
    public SpriteRenderer[] targetSpriteRenderers; // SpriteRenderer'lar� buraya s�r�kleyin veya manuel olarak atay�n
    public ColorSaver colorSaver;

    private void Start()
    {
        if (colorSaver == null)
        {
            Debug.LogError("ColorSaver scripti atanmam��!");
            return;
        }

        // LoadColors fonksiyonunu sahne ba��nda �a��rarak renkleri y�kleyebilirsiniz.
        colorSaver.LoadColors(targetSpriteRenderers);
    }
}
