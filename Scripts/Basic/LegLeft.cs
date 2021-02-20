using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegLeft : MonoBehaviour
{
    [SerializeField] private Transform _hip;
    [SerializeField] private Transform _foot;
    [SerializeField] private ContactFilter2D _filter;
    [SerializeField] private Animator _animator;

    private RaycastHit2D[] _hits = new RaycastHit2D[12];

    private void LateUpdate()
    {
        var hitsCount = Physics2D.Raycast(_hip.position, Vector3.down, _filter, _hits);
        if (hitsCount > 0)
        {
            var first = _hits[0];

            _foot.position = first.point;
            _foot.rotation = Quaternion.FromToRotation(Vector3.up, first.normal);
        }
    }

    private void OnAnimatorIK()
    {
        _animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, 1);
        _animator.SetIKPosition(AvatarIKGoal.LeftFoot, _foot.position);

        _animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, 1);
        _animator.SetIKRotation(AvatarIKGoal.LeftFoot, _foot.rotation);
    }
}
