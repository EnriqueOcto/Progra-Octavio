using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// EJERCICIO
/// 
/// 
/// Realizar el funcionamiento para el disparo automatico de el rifle, pistola y escopeta.
/// El rifle debe de poder disparar automaticamente mientras se mantiene presionado el click izquierdo de el mouse
/// La escopeta y pistola deben de poder disparar 1 vez por click
/// 
/// </summary>
namespace Profe.Weapons
{
    /// <summary>
    /// Este script nos maneja el uso de armas
    /// Controla el inventario de armas
    /// Selecciona cual es el arma que quieres equipar
    /// Y ajusta sus funciones/controles según el arma equipada
    /// </summary>
    public class WeaponHandler : MonoBehaviour
    {

        [SerializeField] private Weapon[] weapons;
        [SerializeField] private Weapon currentWeapon;

        //public GameObject rifle;
        //public GameObject escopeta;
        //public GameObject pistola;
        //private bool isRifleActive;
        //private bool isEscopetaActive;
        //private bool isPistolaActive;


        //void Start()
        //{
        //    WeaponStart();
        //}

        private void Update()
        {
            Aim();

            WeaponSelection();
        }

        private void Aim()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                currentWeapon.Shoot();
            }
        }

        private void WeaponSelection()
        {
            if (Input.GetKeyDown("1"))
            {
                currentWeapon = weapons[0];
                SoundManager.PlaySound(SoundType.CAMBIOARMA);
            }

            if (Input.GetKeyDown("2"))
            {
                currentWeapon = weapons[1];
                SoundManager.PlaySound(SoundType.CAMBIOARMA);
            }

            if (Input.GetKeyDown("3"))
            {
                currentWeapon = weapons[2];
                SoundManager.PlaySound(SoundType.CAMBIOARMA);
            }
        }

        // private void WeaponStart()
        // {
        //     rifle.SetActive(false);
        //     escopeta.SetActive(false);
        //     pistola.SetActive(false);
        //     isRifleActive = true;
        //     isEscopetaActive = true;
        //     isPistolaActive = true;
        // }


        //private void OnTriggerEnter(Collider other)
        //{
        //    if (other.gameObject.CompareTag("Metralleta"))
        //    {
        //        isRifleActive = true;
        //        rifle.SetActive(true);
        //        escopeta.SetActive(false);
        //        Destroy(other.gameObject);
        //        SoundManager.PlaySound(SoundType.CAMBIOARMA);
        //    }
        //    else if (other.gameObject.CompareTag("Escopeta"))
        //    {
        //        isEscopetaActive = true;
        //        escopeta.SetActive(true);
        //        rifle.SetActive(false);
        //        Destroy(other.gameObject);
        //        SoundManager.PlaySound(SoundType.CAMBIOARMA);
        //    }
        //}

    }

}