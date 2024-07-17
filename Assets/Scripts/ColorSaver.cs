using UnityEngine;

public class ColorSaver : MonoBehaviour
{
    public string saveKey = "SavedColors";

    public void SaveColors(SpriteRenderer[] spriteRenderers)
    {
        string colorData = "";

        foreach (SpriteRenderer sr in spriteRenderers)
        {
            colorData += ColorUtility.ToHtmlStringRGB(sr.color) + ",";
        }

        PlayerPrefs.SetString(saveKey, colorData);
        PlayerPrefs.Save();
    }

    public void LoadColors(SpriteRenderer[] spriteRenderers)
    {
        if (PlayerPrefs.HasKey(saveKey))
        {
            string colorData = PlayerPrefs.GetString(saveKey);
            string[] colorStrings = colorData.Split(',');

            for (int i = 0; i < Mathf.Min(spriteRenderers.Length, colorStrings.Length - 1); i++)
            {
                Color color;
                if (ColorUtility.TryParseHtmlString("#" + colorStrings[i], out color))
                {
                    spriteRenderers[i].color = color;
                }
            }
        }
    }
}
