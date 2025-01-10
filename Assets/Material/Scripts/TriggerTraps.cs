using UnityEngine;

public class TriggerTraps : MonoBehaviour
{
    [SerializeField] public GameObject PauseBtn;
    [SerializeField] public GameObject losPannel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PauseBtn.SetActive(false);
            losPannel.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("Triger!");
        }

    }
}

