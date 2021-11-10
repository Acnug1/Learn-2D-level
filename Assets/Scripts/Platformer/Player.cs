using UnityEngine;

namespace Platformer
{
    [RequireComponent(typeof(Animator))]

    public class Player : MonoBehaviour
    {
        private Animator _animator;

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent(out Enemy enemy) || 
                collision.collider.TryGetComponent(out DeathPlayerZone deathPlayerZone))
            {
                _animator.SetTrigger("Death");
                Debug.Log(collision.otherCollider.gameObject.name + " died!");
                collision.otherCollider.enabled = false;
            }  
        }
    }
}
