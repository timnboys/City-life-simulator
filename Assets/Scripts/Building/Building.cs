﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : WorldObject 
{

	public BuildingType type;

	new void Awake() {
		base.Awake ();
	}

}
