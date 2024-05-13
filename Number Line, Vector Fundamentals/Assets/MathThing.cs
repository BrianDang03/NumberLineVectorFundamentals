using UnityEngine;

public class MathThing : MonoBehaviour
{
    [SerializeField] private Transform A;
    [SerializeField] private Transform B;

    [SerializeField] private float scProj = 0f;

    // Draws in Scene View
    private void OnDrawGizmos()
    {
        Vector2 a = A.position;
        Vector2 b = B.position;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(default, a);

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(default, b);

        // Normalizing

        // Manual Version   
        // 
        // Magnitude / Length
        // float aLen = a.magnitude;
        // // Or
        // aLen = Mathf.Sqrt(a.x * a.x + a.y * a.y);
        // 
        // Unit Vector
        // Vector2 aNorm = a / aLen;

        // Quick and Easy Version
        // Unit Vector   
        Vector2 aNorm = a.normalized;
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(aNorm, 0.1f);

        // Scalar Projection
        scProj = Vector2.Dot(aNorm, b);

        // Vector Projection
        Vector2 vecProj = aNorm * scProj;
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(vecProj, 0.05f);


        //Gizmos.DrawLine(a, b);

    }
}
