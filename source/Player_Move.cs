// Player_Move
using UnityEngine;

[AddComponentMenu("Hard Shell Studios/Examples/Player Move")]
public class Player_Move : MonoBehaviour
{
	public bool canMove;

	public float moveSpeed;

	public float sprintMultiplier;

	public float jumpForce;

	private float LODOOHOEFND = 0.5f;

	private Rigidbody PGONDACAPAA;

	private void BEBNOKFLJPH()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void IDIIELPAMCJ()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.JLPPEGBDNKA("w", "player.circle", 1733f) + hardInput.PMJHMIKCPBI("PlayerBase_", 1103f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("mapselector.filter.favoriteonly", "offsets", 461f) + hardInput.GMNJKCNIPGD("curScn", 285f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.CHAJOGCCKDA("Please define the RectTransform for the Center viewport of the scrollable area") && NAEONENECEC())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void IIFCIDDJHPM()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.DAKLFCPPJDB("CameraFilterPack/Distortion_Dream", "_Value", 1462f) + hardInput.PMJHMIKCPBI("_BlurRadius4", 373f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("0.00", "_Value4", 405f) + hardInput.GetAxis("_Value7", 181f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.CHAJOGCCKDA(": ") && PCKCJNKFAPF())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool NAEONENECEC()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 0.5f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 0.5f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 0.1f);
	}

	private bool AHFGFIOCMJF()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 694f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1617f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 867f);
	}

	private bool JLMPFNOJJOK()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 658f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 380f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1652f);
	}

	private void MAOCOEGAFND()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.DAKLFCPPJDB("_TimeX", "(from resources)", 1255f) + hardInput.GetAxis("achievements.21.completed.", 1469f)) * num, PGONDACAPAA.velocity.y, (hardInput.DAKLFCPPJDB("sounds/no_hit", "CameraFilterPack/Blur_DitherOffset", 145f) + hardInput.GetAxis("SetSatelliteSensitivity", 41f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.AADFFLGEJPP("#") && NAEONENECEC())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool NANPNECJKMO()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1030f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 498f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 568f);
	}

	private void DIPDEHOOBPG()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void JAAJECBCCFM()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.JLPPEGBDNKA("_Value", "ExitButton", 1004f) + hardInput.GetAxis("[PlayerController] ", 568f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("_ScreenResolution", "_EmissionGain", 424f) + hardInput.PMJHMIKCPBI("Mouse Wheel Up", 587f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown("Connecting") && AHFGFIOCMJF())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void Start()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void EPEGAEGDJAM()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private bool FDFDMGDFNPP()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1671f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1441f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1447f);
	}

	private void MMOKKAPFGAK()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private bool ICJGHMEFKLD()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1947f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1087f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1723f);
	}

	private void LEAHIBJDMBI()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.JLPPEGBDNKA("<command>", "_ScreenResolution", 804f) + hardInput.GetAxis("_Value4", 593f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("(from resources)", "GlassDistortion", 1603f) + hardInput.GMNJKCNIPGD("_TimeX", 1714f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.CHAJOGCCKDA(". local RequestedView.ownerId: ") && NAMJGDMJNPN())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool FFNDLLMCLBE()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 8f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1844f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 101f);
	}

	private bool JKMFLNFDNEF()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1137f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 643f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 804f);
	}

	private void FABKIGNFECE()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.DAKLFCPPJDB("colorD", "_Value4", 784f) + hardInput.GMNJKCNIPGD("_Value3", 740f)) * num, PGONDACAPAA.velocity.y, (hardInput.DAKLFCPPJDB("_Fade", "CameraFilterPack/EyesVision_1", 991f) + hardInput.GMNJKCNIPGD("</color>", 759f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown(" : ") && FFNDLLMCLBE())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void OEENOOGEEHD()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.GetAxis("Tab2Content", "_LightIntensity", 1832f) + hardInput.GMNJKCNIPGD("Drop_Far", 364f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("menu.selectedlevelid", "_AccumOrig", 1813f) + hardInput.PMJHMIKCPBI("CameraFilterPack/Color_Sepia", 748f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NGFFMGKPMNP("Drop_Floor_Fluid") && FBMAFPFLLMB())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool NAMJGDMJNPN()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1917f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 726f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 627f);
	}

	private bool LBIPPEAGECA()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 691f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 130f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1248f);
	}

	private void FABMDEHEDNO()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.JLPPEGBDNKA("player.goldarc", "_ScreenResolution", 1044f) + hardInput.PMJHMIKCPBI("Joystick1Button3", 1110f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("PunPickup", "id", 1432f) + hardInput.GMNJKCNIPGD("DifficultyBG", 95f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NGFFMGKPMNP("_RotationMatrix") && FFNDLLMCLBE())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void DLBODOFAJGM()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void MFMIODIAKNI()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.GetAxis("_ScreenResolution", "maps.", 864f) + hardInput.GMNJKCNIPGD("_Value", 220f)) * num, PGONDACAPAA.velocity.y, (hardInput.JLPPEGBDNKA("float,10", "_Blue_G", 337f) + hardInput.GetAxis("_TimeX", 653f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NGFFMGKPMNP("_TimeX") && FFNDLLMCLBE())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void AGEJKLMJGDO()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void JKFDDNMPOJH()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void KLILJHJNICK()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private bool KBHPPEAGMJB()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1134f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 267f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 356f);
	}

	private bool FBMAFPFLLMB()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 667f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 219f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 879f);
	}

	private void LCJHDLKJEOM()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.JLPPEGBDNKA("_Value", "_ScreenResolution", 77f) + hardInput.GMNJKCNIPGD("CameraFilterPack_3D_Myst1", 1894f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis(":", "#done", 1762f) + hardInput.GMNJKCNIPGD("_TimeX", 1562f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.AADFFLGEJPP("BitsData") && JLMPFNOJJOK())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool PCKCJNKFAPF()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1013f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 403f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 482f);
	}

	private void Update()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.GetAxis("Right", "Left", 7f) + hardInput.GetAxis("ControllerLeftX", 7f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("Forward", "Backward", 7f) + hardInput.GetAxis("ControllerLeftY", 7f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown("Jump") && NAEONENECEC())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void NCNPAKFAFOE()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void CCLNNLCOPBL()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void AGMJDGHLBMN()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.GetAxis("GenerationMenu", "_TimeX", 974f) + hardInput.PMJHMIKCPBI("float,50", 1518f)) * num, PGONDACAPAA.velocity.y, (hardInput.JLPPEGBDNKA("Bad parameters for delete! Use <key>", "Warning: No Shape Curve set for CurveWaveform.cs on ", 1834f) + hardInput.PMJHMIKCPBI("LetterSpacing: Missing Text component", 137f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.CHAJOGCCKDA(".lastCheckpoint.lives") && NAMJGDMJNPN())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void CNGAJDBOCLJ()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void FEHCNJLLJMP()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}
}
