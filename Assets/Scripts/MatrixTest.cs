using UnityEngine;

public class MatrixTest : MonoBehaviour
{
    private void Start()
    {
        var t =
            // 1
            // Matrix4x4.Rotate(Quaternion.Euler(0, -90, 0)) *
            // Matrix4x4.Rotate(Quaternion.Euler(-90, 0, 0)) *

            // 2
            // Matrix4x4.Translate(new Vector3(0, 0, -1)) *
            // Matrix4x4.Rotate(Quaternion.Euler(180, 0, 0)) *
            // Matrix4x4.Rotate(Quaternion.Euler(0, 0, 90)) *

            // 3
            // Matrix4x4.Rotate(Quaternion.Euler(0, 180, 0)) *
            // Matrix4x4.Translate(new Vector3(1, 0, 0)) *

            // 4
            // new Matrix4x4(new Vector4(-1, 0, 0, 0), new Vector4(0, -1, 0, 0), new Vector4(0, 0, 1, 0), new Vector4(0, 0, 0, 1)) *
            // new Matrix4x4(new Vector4(1, 0, 0, 0), new Vector4(0, 1, 0, 0), new Vector4(0, 0, 1, 0), new Vector4(-1, 0, 0, 1)) *
            
            Matrix4x4.identity;

        var e = t.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(-e.z, -e.y, -e.x);
        transform.position = new Vector3(t[2, 3], t[1, 3], t[0, 3]);

        Debug.Log(t);
    }
}
