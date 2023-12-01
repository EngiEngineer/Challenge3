using UnityEngine;

public class AnimatorTrigger : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] string _triggerName;
    [SerializeField] bool _armsLayer = false;

    private void OnTriggerEnter(Collider other)
    {
        _animator.SetTrigger(_triggerName);

        if (_armsLayer)
        {
            _animator.SetLayerWeight(1, 1f);
        }
        else if (!_armsLayer)
        {
            _animator.SetLayerWeight(1, 0f);
        }
    }
}
