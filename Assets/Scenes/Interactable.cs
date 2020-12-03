using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    public Rigidbody figureRigidbody;
    public float force = 1;
    public float gravity = -10;
    public Vector3 originalPosition;

    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity= (new Vector3(0, gravity, 0));
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (_transform.localPosition.y < originalPosition.y)
        {
            
            _transform.localPosition = originalPosition;

        }
        
        
    }

    public void OnMouseDown()
    {

        figureRigidbody.AddRelativeForce(Vector3.up * force, ForceMode.Impulse);
    }
}
