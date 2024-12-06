using UnityEngine;

public class BackgroundMusicVolume : MonoBehaviour
{
    public Transform cameraTransform; 
    public AudioSource audioSource; 
    public float maxDistance; 
    public float minDistance; 

    private void Update()
    {
        AdjustVolumeBasedOnDistance();
    }

    private void AdjustVolumeBasedOnDistance()
    {
        if (cameraTransform == null || audioSource == null)
            return;

        float zDistance = Mathf.Abs(cameraTransform.position.z - transform.position.z);

        Debug.Log(zDistance);

        float volume = Mathf.Clamp(0.7f - (zDistance - minDistance) / (maxDistance - minDistance) * 0.7f, 0f, 0.7f);

        audioSource.volume = volume;
    }
}
