using UnityEngine;

public class ActivatePlatform : MonoBehaviour
{
    public GameObject platform;

    private void Start()
    {
        platform.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        platform.SetActive(true);
    }
}