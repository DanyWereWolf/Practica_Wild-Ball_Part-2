using UnityEngine;

public class TriggerMagicBridge : MonoBehaviour
{
    public GameObject BridgeExit;
    public GameObject BridgeEnter;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BridgeEnter.SetActive(true);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        BridgeExit.SetActive(false);
    }
}

