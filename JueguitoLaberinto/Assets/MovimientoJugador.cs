using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.UIElements.Cursor;

public class MovimientoJugador : MonoBehaviour {
    public float velocidad; 
    public float velocidadRotacion;
    private Rigidbody fisicas;
    
    
    void Start() {
        fisicas = GetComponent<Rigidbody>();
    }
    
    void Update() {
        var horizontal = Input.GetAxis("Horizontal"); 
        var vertical = Input.GetAxis("Vertical");
        var movimiento = new Vector3(-horizontal, 0, -vertical).normalized *
                                (Time.deltaTime * velocidad);
        transform.Translate(movimiento);

        var mouseX = Input.GetAxis("Mouse X");
        var rotacion = new Vector3(0, mouseX, 0) * (Time.deltaTime * velocidadRotacion);
        transform.Rotate(rotacion);
        
    }
}