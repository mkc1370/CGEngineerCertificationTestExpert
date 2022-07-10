using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField][Range(0,360)] private float range;
    [SerializeField] private Transform a;
    [SerializeField] private Transform b;

    private void Update()
    {
        a.localRotation = Quaternion.Euler(0, 0, range * -2 + 90);
        b.localRotation = Quaternion.Euler(0, 0, range * 3);
    }
}
