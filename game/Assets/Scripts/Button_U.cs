﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_U : MonoBehaviour {

	public void Button_Click(){

		GameObject.Find ("Canvas").GetComponent ("submit_Script").SendMessage ("get_u");
	}
}
