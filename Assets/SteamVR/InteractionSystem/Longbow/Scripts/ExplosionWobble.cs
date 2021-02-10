//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Makes the weeble wobble
//
//=============================================================================

using UnityEngine;
using System.Collections;


namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	public class ExplosionWobble : MonoBehaviour
	{
int count = 0;
		//-------------------------------------------------
		public void ExplosionEvent( Vector3 explosionPos )
		{
			ParticleSystem exp = GetComponent<ParticleSystem>();
			exp.Play();
			Destroy(gameObject, exp.main.duration);
			count = Random.Range(1, 10);
		}
	}
}
