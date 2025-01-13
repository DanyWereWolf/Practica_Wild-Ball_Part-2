using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    [SerializeField] public GameObject losPannel;
    [SerializeField] public GameObject PauseBtn;
    [SerializeField] public ParticleSystem particleSystem; // —сылка на систему частиц

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrel"))
        {
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Player"))
        {
            particleSystem.Play();
            Time.timeScale = 0f;
            PauseBtn.SetActive(false);
            losPannel.SetActive(true);
        }
    }
}
