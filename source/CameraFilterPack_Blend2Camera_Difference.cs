// CameraFilterPack_Blend2Camera_Difference
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Difference")]
public class CameraFilterPack_Blend2Camera_Difference : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Difference";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	private RenderTexture JDMCFBKJHDD;

	private Material NBPKMLMCHFN
	{
		get
		{
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return BJFKDHHMLJH;
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return BJFKDHHMLJH;
	}

	private void LIEGJOHINGC()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHICDLBKEJN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -61);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 200f)
			{
				HBJJOCHGOPH = 293f;
			}
			if (Camera2 != null)
			{
				HFBJAOFLCJI().SetTexture(" respawn in future: ", JDMCFBKJHDD);
			}
			NDMPCDHADMJ().SetFloat("EnvironmentSlider", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("#rt", BlendFX);
			EPCGJFCCAFH().SetFloat("{\"items\":", SwitchCameraToCamera2);
			NFMGLIKNOOC().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1330f, 668f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnEnable()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DBIBFOINCKM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 26);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PLIKADJCEPO()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return BJFKDHHMLJH;
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1462f)
			{
				HBJJOCHGOPH = 813f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			NDMPCDHADMJ().SetFloat("_Offsets", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat(" but this PhotonView does not exist! Was remote PV.", BlendFX);
			KBOPGONOCNP().SetFloat("================================", SwitchCameraToCamera2);
			OIMMPLPBLBK().SetVector("Up", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1496f, 1331f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void JILOMOBDPIA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 5);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1124f)
			{
				HBJJOCHGOPH = 1913f;
			}
			if (Camera2 != null)
			{
				EPCGJFCCAFH().SetTexture(": ", JDMCFBKJHDD);
			}
			EMDFHOKEGNG().SetFloat(" | ", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/NightVision_4", BlendFX);
			OIMMPLPBLBK().SetFloat("\" gets executed locally only, if at all.", SwitchCameraToCamera2);
			EPCGJFCCAFH().SetVector("AudioSampler", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1166f, 1218f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value2", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MPADDMNGJNC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -95);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DAHFFNNIGML()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -121);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EDBEHEKMGFH()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void OFBLDOCCBBN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 8);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LNIOFCGDDKP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 19);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void BMIOFJFMCBG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -115);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PAEGLMEOKHP()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 350f)
			{
				HBJJOCHGOPH = 903f;
			}
			if (Camera2 != null)
			{
				EMDFHOKEGNG().SetTexture("USE_PREDICATION", JDMCFBKJHDD);
			}
			EMDFHOKEGNG().SetFloat("_Value", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("SetRoomStartTimestamp", BlendFX);
			NDMPCDHADMJ().SetFloat("CameraFilterPack/FX_Spot", SwitchCameraToCamera2);
			HCGJCMDJPGD().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1099f, 1939f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return BJFKDHHMLJH;
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1537f)
			{
				HBJJOCHGOPH = 766f;
			}
			if (Camera2 != null)
			{
				NDMPCDHADMJ().SetTexture("CameraFilterPack_AAA_Blood1", JDMCFBKJHDD);
			}
			NDMPCDHADMJ().SetFloat("_ChangeGreen", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("OK", BlendFX);
			NFMGLIKNOOC().SetFloat("PLEASE WAIT", SwitchCameraToCamera2);
			EPCGJFCCAFH().SetVector("Set sun directionVector - in which direction sun will grow on beat", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 282f, 939f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 311f)
			{
				HBJJOCHGOPH = 543f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("#ok", JDMCFBKJHDD);
			}
			EMDFHOKEGNG().SetFloat("[EditorEvent] Exception: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("shader.frost", BlendFX);
			NDMPCDHADMJ().SetFloat("Failed to 'GetKeyCode' for key: ", SwitchCameraToCamera2);
			HCGJCMDJPGD().SetVector("MenuScene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 684f, 1887f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IJCBBIJOCAH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 96);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 340f)
			{
				HBJJOCHGOPH = 1148f;
			}
			if (Camera2 != null)
			{
				PLBEJJIHFPB().SetTexture("resetach21", JDMCFBKJHDD);
			}
			OIMMPLPBLBK().SetFloat("Set sun beat detection sensitivity", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", BlendFX);
			EPCGJFCCAFH().SetFloat("MapFolderInputField", SwitchCameraToCamera2);
			KAFBNOBOIAJ().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1545f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDPOFMCFBMF()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void GEGDELOFIML()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -52);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DCGFEIBKOBB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -118);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void OnValidate()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void BGDONBMDPGM()
	{
	}

	private void DLBODOFAJGM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 64);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void NDAJBJFJGCF()
	{
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1442f)
			{
				HBJJOCHGOPH = 1618f;
			}
			if (Camera2 != null)
			{
				KBOPGONOCNP().SetTexture("f", JDMCFBKJHDD);
			}
			KAFBNOBOIAJ().SetFloat("_Value", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("Items/", BlendFX);
			EPCGJFCCAFH().SetFloat("_Bullet_5", SwitchCameraToCamera2);
			EPCGJFCCAFH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1306f, 849f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GFLAINNLMBO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -29);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	private void JHLGHODFJOO()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BFEILOMHNPC()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BNEJMABFKJE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNBPKNNBMDI()
	{
	}

	private void NJHJHBOJKIC()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1244f)
			{
				HBJJOCHGOPH = 1999f;
			}
			if (Camera2 != null)
			{
				OIMMPLPBLBK().SetTexture("_Value7", JDMCFBKJHDD);
			}
			HFBJAOFLCJI().SetFloat("ChallengesButton", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_Smooth", BlendFX);
			HCGJCMDJPGD().SetFloat("GlassAberration", SwitchCameraToCamera2);
			NDMPCDHADMJ().SetVector("CameraFilterPack/Blend2Camera_SplitScreen", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 399f, 1159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
