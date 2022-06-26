using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    #region Variable
    [SerializeField] private GameObject bullet; //Variable que guarda el prefab de la bala.

    [SerializeField] private float timeToSpawn; //Variable de tiempo entre una bala y otra.
    [SerializeField] private float timeToDestroy; //Variable de tiempo antes de destruir la bala.
    #endregion

    #region Monobehaviour Method
    private void Start()
    {
        StartCoroutine(SpawnBullet()); //Iniciamos la corrutina.
    }
    #endregion
    #region Corroutines
    /// <summary>
    /// Corrutina que instancia una bala cada tantos segundos como indique la variable.
    /// </summary>
    IEnumerator SpawnBullet()
    {
        while (true)
        {
            GameObject tmp = Instantiate(bullet, this.transform.position, this.transform.rotation); //Instanciamos bala.
            Destroy(tmp, timeToDestroy); //Aplicamos la destrucción en el tiempo.
            yield return new WaitForSeconds(timeToSpawn); //Esperamos a la siguiente vuelta.
        }
    }
    #endregion
}
