using UnityEngine;

public class ButtonDeleteObjects : MonoBehaviour
{

    public void DestroyObject()
    {
        // Procurar todos os objetos na cena com o nome especificado
        GameObject[] objects = GameObject.FindGameObjectsWithTag("visualizer");

        // Verificar se algum deles est� ativado
        foreach (GameObject obj in objects)
        {
            if (obj.activeSelf)
            {
                // Destruir o pai do objeto ativado
                Destroy(obj.transform.parent.gameObject);
                break; // Sair do loop assim que um objeto ativado for destru�do
            }
        }
    }
}