﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foguete : MonoBehaviour { 
    Rigidbody rigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent <Rigidbody>(); //Acesso ao Componente Rigidbody na Unity
    }

    // Update is called once per frame
    private void Update()
    {
        ControleTeclado();
    }
    private void ControleTeclado()
    {
        if (Input.GetKey(KeyCode.Space)) // Comando utilizado para identificar uma tecla pressionada
        {
            rigidBody.AddRelativeForce(Vector3.forward);
            print("acelerando");  // Ação Realizada pelo comando
        }
        if (Input.GetKey(KeyCode.A)) // Comando utilizado para identificar uma tecla pressionada
        {
            transform.Rotate(-Vector3.right);
            print("giro esquerda"); // Ação Realizada pelo comando
        }
        else if (Input.GetKey(KeyCode.D)) // Comando utilizado para identificar uma tecla pressionada
        {
            transform.Rotate(-Vector3.left);
            print("giro direita"); // Ação Realizada pelo comando
        }
    }
}
