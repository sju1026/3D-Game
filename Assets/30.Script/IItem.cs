using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IItem : MonoBehaviour
{
    public enum Type
    {
        Ammo, Coin, Grenade, Heart, Weapon
    };
    public Type type;
    public int value;

    Rigidbody rigid;
    SphereCollider spherCollider;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        spherCollider = GetComponent<SphereCollider>();
    }

    void Update()
    {
        transform.Rotate(Vector3.up * 20f * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            rigid.isKinematic = true;
            spherCollider.enabled = false;
        }
    }
}
