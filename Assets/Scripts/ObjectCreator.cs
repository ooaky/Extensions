using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ObjectCreator : MonoBehaviour
{
    // Cria um item de menu na barra superior do Unity
    [MenuItem("Ferramentas/Criar Objeto")]
    public static void ShowObjectCreationMenu()
    {
        // Mostra um menu para selecionar o tipo de objeto
        int choice = EditorUtility.DisplayDialogComplex(
            "Criar Objeto",
            "Escolha um tipo de objeto para criar:",
            "Cubo",
            "Esfera",
            "Cilindro"
        );

        // Determina qual objeto criar com base na escolha do usuário
        switch (choice)
        {
            case 0:
                // Cria um cubo
                GameObject.CreatePrimitive(PrimitiveType.Cube);
                break;
            case 1:
                // Cria uma esfera
                GameObject.CreatePrimitive(PrimitiveType.Sphere);
                break;
            case 2:
                // Cria um cilindro
                GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                break;
            default:
                // Caso o usuário cancele
                break;
        }
    }
}
