using UnityEngine;

public class Farmer : MonoBehaviour
{
    CharacterController cc;

    public float speed = 5f;
    public float gravity = -9.81f;
    public Transform bodyTransform;

    void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Gravity();
    }

    public void Move(Vector3 direction)
    {
        if (direction == Vector3.zero)
        {
            return;
        }

        cc.Move(direction * speed * Time.deltaTime);
        bodyTransform.rotation = Quaternion.LookRotation(direction);
    }

    public void Gravity()
    {
        cc.Move(new Vector3(0, 1, 0) * gravity * Time.deltaTime);
    }

}
