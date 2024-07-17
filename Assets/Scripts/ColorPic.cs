using UnityEngine;

public class ColorPic : MonoBehaviour
{
    public SpriteRenderer[] targetSpriteRenderers;
    public ColorSaver colorSaver;

    private void OnMouseDown()
    {
        if (colorSaver != null)
        {
            colorSaver.SaveColors(targetSpriteRenderers);
        }
        else
        {
            Debug.LogError("ColorSaver scripti atanmamis!");
        }
    }
}
