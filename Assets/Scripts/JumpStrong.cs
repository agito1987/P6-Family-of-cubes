using UnityEngine;

public class JumpStrong : Jump { //Inheritance
  private float _currentTime;
  private int _colorIndexOld, _colorIndexNew;
  private readonly Color[] _colors = { new(0, .75f, .5f, 1), new(1, 1, 0, 1), new(.8f, 0, .5f, 1), new(1, .5f, 0, 1) };
  private Renderer _renderer;
  
  protected new void Start() {
    base.Start();
    Strength = 60f;
    _renderer = GetComponent<Renderer>();
  }

  private void ChangeColor() {
    _colorIndexOld = _colorIndexNew;
    _colorIndexNew = Random.Range(0, 4);
    if (_colorIndexNew == _colorIndexOld)
      while (_colorIndexNew == _colorIndexOld)
        _colorIndexNew = Random.Range(0, 4);
    
    _renderer.material.color = _colors[_colorIndexNew];
  }

  protected override void OnMouseDown() { //Polymorphism
    base.OnMouseDown();
    ChangeColor();
    
  }
}
