using UnityEngine;

public class ParticleTrigger : MonoBehaviour
{
    [SerializeField] public ParticleSystem particleSystem; // —сылка на систему частиц

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ”бедитесь, что у вашего объекта игрока установлен тег "Player"
        {
            particleSystem.Play();
        }
    }
}