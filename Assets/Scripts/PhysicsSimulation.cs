using UnityEngine;

public class PhysicsSimulation : MonoBehaviour
{
    private void Update()
    {
        Physics2D.Simulate(Time.fixedDeltaTime);
    }    
}
