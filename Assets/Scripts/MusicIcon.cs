using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MüzikIcon : MonoBehaviour
{
    [SerializeField] public Image soundOnIcon;
    [SerializeField] public Image soundOffIcon;
    [SerializeField] public Button musicButton;

    private bool isMuted;

    private void Start()
    {
        // Eğer bu obje daha önce oluşturulmuşsa, bu objeyi yok et
        if (FindObjectsOfType<MüzikIcon>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        // Bu objeyi yok etme
        DontDestroyOnLoad(gameObject);

        // Referansları tekrar kontrol et ve ayarla
        CheckAndSetReferences();

        // OnClick metodu dinamik olarak atanıyor
        musicButton.onClick.AddListener(OnMusicButtonClick);

        // AudioListener.pause ayarını set et
        AudioListener.pause = isMuted;

        // Scene değişikliği event'ini dinle
        SceneManager.sceneLoaded += OnSceneLoaded;

        // İlk durumu güncelle
        UpdateButtonIcon();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Scene değiştiğinde referansları tekrar kontrol et ve ayarla
        CheckAndSetReferences();

        // Buton ikonlarını güncelle
        UpdateButtonIcon();
    }

    public void OnButtonPress()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        Save();
        UpdateButtonIcon();
    }

    private void UpdateButtonIcon()
    {
        if (musicButton == null)
            return;
        if (!isMuted)
        {
            soundOnIcon.enabled = true;
            soundOffIcon.enabled = false;
        }
        else
        {
            soundOnIcon.enabled = false;
            soundOffIcon.enabled = true;
        }
    }

    private void Save()
    {
        PlayerPrefs.SetInt("isMuted", isMuted ? 1 : 0);
    }

    private void CheckAndSetReferences()
    {
        // Referanslar null ise veya atanmamışsa, tekrar atama işlemlerini yap
        if (soundOnIcon == null || soundOffIcon == null || musicButton == null)
        {
            // Örnek olarak, sahnede bulunan bir nesnenin referanslarını kullanabilirsiniz
            GameObject soundOnObject = GameObject.Find("MüzikOn");
            GameObject soundOffObject = GameObject.Find("MüzikOff");
            GameObject musicButtonObject = GameObject.Find("Müzik");

            if (soundOnObject != null)
                soundOnIcon = soundOnObject.GetComponent<Image>();

            if (soundOffObject != null)
                soundOffIcon = soundOffObject.GetComponent<Image>();

            if (musicButtonObject != null)
                musicButton = musicButtonObject.GetComponent<Button>();

            // OnClick metodu dinamik olarak atanıyor
            if (musicButton != null)
                musicButton.onClick.AddListener(OnMusicButtonClick);
        }
    }

    private void OnMusicButtonClick()
    {
        // Müzik butonuna tıklandığında yapılacak işlemler buraya yazılır
        OnButtonPress();
    }
}
