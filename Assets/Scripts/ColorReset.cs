using UnityEngine;

public class ColorReset : MonoBehaviour
{
    public string[] saveKeys = { "SavedColors", "SavedScores", "PlayerSettings" };

    public void ChangeColors()
    {
        foreach (string key in saveKeys)
        {
            // PlayerPrefs.GetString ile anahtarın değerini alabiliriz
            string colorHex = "#FFFFFF"; // Varsayılan beyaz renk

            // String formatındaki renk kodunu Unity'nin Color sınıfına dönüştürüyoruz
            if (ColorUtility.TryParseHtmlString(colorHex, out Color color))
            {
                // Color'u string formatına dönüştürüp PlayerPrefs'e kaydediyoruz
                string colorData = "#" + ColorUtility.ToHtmlStringRGB(color);
                PlayerPrefs.SetString(key, colorData);
                PlayerPrefs.Save();
            }
        }
    }
}
