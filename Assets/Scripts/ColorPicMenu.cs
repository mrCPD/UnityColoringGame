using UnityEngine;

public class ColorPicMenu : MonoBehaviour
{
    public SpriteRenderer[] targetSpriteRenderers; // SpriteRenderer'larý buraya sürükleyin veya manuel olarak atayýn
    public ColorSaver colorSaver;

    private void Start()
    {
        if (colorSaver == null)
        {
            Debug.LogError("ColorSaver scripti atanmamýþ!");
            return;
        }

        // LoadColors fonksiyonunu sahne baþýnda çaðýrarak renkleri yükleyebilirsiniz.
        colorSaver.LoadColors(targetSpriteRenderers);
    }
}
