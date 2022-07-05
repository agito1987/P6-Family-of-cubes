using System;
using UnityEngine;

public abstract class Jump : MonoBehaviour { //Abstraction


  private float _strength = 40f;
  private const float _minStrength = 0f;
  private const float _maxStrength = 60f;
  public Rigidbody rb;

  protected float Strength { //Encapsulation
    get => _strength;
    set {
      _strength = Mathf.Clamp(value, _minStrength, _maxStrength);
    }
  }

  private protected void Start() {
    rb = gameObject.GetComponent<Rigidbody>();
  }

  protected virtual void OnMouseDown() { //Polymorphism
    rb.AddForce(Vector3.up * Strength * 10);
  }
}
