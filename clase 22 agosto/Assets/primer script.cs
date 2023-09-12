using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primerscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int numero = 3;
        int kolacao = 6;
        int michifuz = 9;

        //hacer una resta con los datos//

        EscribirAConsola(numero);

        EscribirAConsola(kolacao);

        EscribirAConsola(michifuz);

        
        int retorno = RestarNumeros(michifuz, kolacao);
        EscribirAConsola(retorno);
    }
    void EscribirAConsola(int dato)

    {

        Debug.Log(dato);

    }

    int RestarNumeros(int PrimerNumero, int SegundoNumero)
    {
        int resultado = SegundoNumero - PrimerNumero;
        return resultado;
    }
 }
