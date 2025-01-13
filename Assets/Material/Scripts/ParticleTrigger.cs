using UnityEngine;

public class ParticleTrigger : MonoBehaviour
{
    [SerializeField] public ParticleSystem particleSystem; // ������ �� ������� ������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ���������, ��� � ������ ������� ������ ���������� ��� "Player"
        {
            particleSystem.Play();
        }
    }
}