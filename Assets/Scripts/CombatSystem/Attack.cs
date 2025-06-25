using Timers;
using UnityEngine;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] private UnityEvent attack;
    
    private bool _canAttack = true;
    // unity���ڽ�����
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DealDamage(collision);
    }

    private void CanAttack()
    {
        _canAttack = true;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        DealDamage(other);
    }

    private void DealDamage(Collider2D other)
    {
        if (!_canAttack) return;

        if (other.CompareTag(targetTag))
        {
            var damageable = other.GetComponent<Damageable>();
            damageable.TakeDamage(1);
            TimersManager.SetTimer(this, 1, CanAttack);
            _canAttack = false;
            attack.Invoke();
        }
    }
}