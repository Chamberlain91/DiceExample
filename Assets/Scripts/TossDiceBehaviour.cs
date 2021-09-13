using UnityEngine;

public class TossDiceBehaviour : MonoBehaviour
{
    public Rigidbody rigidbody;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var x = Random.Range(-2f, +2f);
            var z = Random.Range(-2f, +2f);
            rigidbody.position = new Vector3(x, 2, z);

            rigidbody.angularVelocity = Random.onUnitSphere * 45;
            rigidbody.velocity = Random.onUnitSphere * 5;
        }
    }
}
