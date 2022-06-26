using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    #region Variables
    [SerializeField] private int direction; //Variable que indica la dirección de la bala.
    [SerializeField] private float speed; //Variable que indica la velocidad de la bala.
    [SerializeField] private float damage; //Variable que indica el daño de la bala.
    #endregion
    #region Monobehaviour method
    private void Update()
    {
        //Movemos la bala en función de la dirección dada en la velocidad indicada.
        transform.Translate((Vector3.right * direction) * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScaleUp();
        }
    }
    #endregion
    #region Private method
    private void ScaleUp()
    {
        this.transform.localScale *= 2;
    }
    #endregion
}
