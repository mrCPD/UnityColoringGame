using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] musicList;
    private AudioSource audioSource;
    private List<int> remainingIndices;  // Müzik listesindeki kullanılmamış indeksleri saklar

    private static MusicManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
            InitializeIndices();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void InitializeIndices()
    {
        remainingIndices = new List<int>();
        for (int i = 0; i < musicList.Length; i++)
        {
            remainingIndices.Add(i);
        }
    }

    private void Start()
    {
        PlayRandomTrack();
    }

    private void Update()
    {
        // Müzik bitene kadar bekleyip bir sonraki parçayı çal
        if (!audioSource.isPlaying)
        {
            PlayRandomTrack();
        }
    }

    private void PlayRandomTrack()
    {
        if (musicList.Length > 0 && remainingIndices.Count > 0)
        {
            int randomIndex = Random.Range(0, remainingIndices.Count);
            int selectedIndex = remainingIndices[randomIndex];

            audioSource.clip = musicList[selectedIndex];
            audioSource.Play();

            remainingIndices.RemoveAt(randomIndex);
        }
        else
        {
            // Tüm müzikler oynatıldıysa, indeksleri tekrar başlat
            InitializeIndices();
            PlayRandomTrack();
        }
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
}
