using UnityEngine;

public class BackgroundMusicVolume : MonoBehaviour
{
    public Transform cameraTransform; 
    public AudioSource audioSource; 
    public float maxDistance = 100f; 
    public float minDistance = 50f; 

    private void Update()
    {
        AdjustVolumeBasedOnDistance();
    }

    private void AdjustVolumeBasedOnDistance()
    {
        if (cameraTransform == null || audioSource == null)
            return;

        float zDistance = Mathf.Abs(cameraTransform.position.z - transform.position.z);

        float volume = Mathf.Clamp01(1 - (zDistance - minDistance) / (maxDistance - minDistance));

        // Set the audio volume
        audioSource.volume = volume;
    }
}
