using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    [SerializeField] public GameObject losPannel;
    [SerializeField] public GameObject PauseBtn;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrel"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Player"))
        {
            PauseBtn.SetActive(false);
            losPannel.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("Triger!");
        }
    }
}
