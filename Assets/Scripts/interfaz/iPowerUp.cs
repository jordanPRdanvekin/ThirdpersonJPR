using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iPowerUp
{ 
    //creamos nuestra primera interfas de control modular para controlar todos los scritps de powerups el game object le dice a todos quien es quien. 
    public void PickupPowerup(GameObject other);
}
